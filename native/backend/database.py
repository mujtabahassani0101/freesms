from __future__ import annotations

import contextlib
import json
import os
from pathlib import Path
import secrets
import subprocess
import sys
import time
from dataclasses import dataclass

import pymssql

PROJECT = Path(sys._MEIPASS) if getattr(sys, 'frozen', False) else Path(__file__).resolve().parents[2]
IMAGE = 'mcr.microsoft.com/mssql/server:2019-latest'


class DatabaseError(RuntimeError):
    pass


@dataclass(frozen=True)
class DatabaseConfig:
    directory: Path
    container: str = 'free-sms-database'
    port: int = 15436
    database: str = 'free_sms'
    volume: str = 'free-sms-data'

    @classmethod
    def default(cls):
        if sys.platform == 'win32':
            data = Path(os.environ.get('LOCALAPPDATA', str(Path.home() / 'AppData/Local')))
        else:
            data = Path(os.environ.get('XDG_DATA_HOME', str(Path.home() / '.local/share')))
        return cls(data / 'free-sms')


class Database:
    def __init__(self, config: DatabaseConfig | None = None):
        self.config = config or DatabaseConfig.default()
        self.config.directory.mkdir(parents=True, exist_ok=True, mode=0o700)
        self.env_path = self.config.directory / 'database.env'
        if not self.env_path.exists():
            self.env_path.write_text(
                'ACCEPT_EULA=Y\nMSSQL_PID=Developer\n'
                f'MSSQL_SA_PASSWORD=Md!{secrets.token_urlsafe(30)}\n'
                'MSSQL_MEMORY_LIMIT_MB=2048\n', encoding='utf-8'
            )
            self.env_path.chmod(0o600)
        self.password = dict(line.split('=', 1) for line in self.env_path.read_text(encoding='utf-8').splitlines() if '=' in line)['MSSQL_SA_PASSWORD']

    def docker(self, *arguments, **kwargs):
        result = subprocess.run(['docker', *arguments], capture_output=True, text=True, **kwargs)
        if result.returncode:
            raise DatabaseError(result.stderr.strip() or result.stdout.strip())
        return result.stdout

    def ensure_server(self):
        try:
            inspected = subprocess.run(
                ['docker', 'container', 'inspect', self.config.container],
                capture_output=True, text=True, check=False,
            )
            if inspected.returncode:
                self.docker('run', '-d', '--name', self.config.container,
                    '--env-file', str(self.env_path),
                    '-p', f'127.0.0.1:{self.config.port}:1433',
                    '--mount', f'type=volume,src={self.config.volume},dst=/var/opt/mssql',
                    '--memory', '3g', '--cpus', '2', IMAGE)
            elif not json.loads(inspected.stdout)[0]['State']['Running']:
                self.docker('start', self.config.container)
        except FileNotFoundError as exc:
            raise DatabaseError('Docker Desktop را نصب و اجرا کنید؛ حالت Linux containers باید فعال باشد.') from exc
        for attempt in range(45):
            try:
                with self.connection('master', autocommit=True):
                    return
            except pymssql.Error:
                if attempt == 44:
                    raise DatabaseError('ارتباط با بانک اطلاعاتی برقرار نشد؛ وضعیت Docker را بررسی کنید.')
                time.sleep(1)

    def connection(self, database=None, *, autocommit=False):
        return pymssql.connect(server='127.0.0.1', port=self.config.port,
            user='sa', password=self.password, database=database or self.config.database,
            charset='UTF-8', login_timeout=3, timeout=60, autocommit=autocommit, as_dict=True)

    def ensure_database(self):
        self.ensure_server()
        with self.connection('master', autocommit=True) as connection:
            cursor = connection.cursor()
            cursor.execute('SELECT DB_ID(%s) AS id', (self.config.database,))
            if cursor.fetchone()['id'] is None:
                if not self.config.database.replace('_', '').isalnum():
                    raise DatabaseError('Invalid application database identifier')
                for name, destination in [('school_af_kbr_Data.MDF', self.config.database + '.mdf'), ('school_af_kbr_Log.LDF', self.config.database + '.ldf')]:
                    self.docker('cp', str(PROJECT / 'original/installed/db' / name),
                        self.config.container + ':/var/opt/mssql/data/' + destination)
                self.docker('exec', '-u', '0', self.config.container, 'chown', 'mssql:root',
                    f'/var/opt/mssql/data/{self.config.database}.mdf', f'/var/opt/mssql/data/{self.config.database}.ldf')
                # The database identifier is application-owned, never entered by a user.
                if not self.config.database.replace('_', '').isalnum():
                    raise DatabaseError('Invalid application database identifier')
                cursor.execute(f"CREATE DATABASE [{self.config.database}] ON "
                    f"(FILENAME='/var/opt/mssql/data/{self.config.database}.mdf'),"
                    f"(FILENAME='/var/opt/mssql/data/{self.config.database}.ldf') FOR ATTACH")
        return self

    def query(self, sql, parameters=()):
        with self.connection() as connection:
            cursor = connection.cursor(as_dict=False)
            cursor.execute(sql, parameters or None)
            if not cursor.description:
                return []
            names = [column[0] or f'Column{i + 1}' for i, column in enumerate(cursor.description)]
            return [dict(zip(names, row)) for row in cursor.fetchall()]

    def scalar(self, sql, parameters=(), default=None):
        rows = self.query(sql, parameters)
        return next(iter(rows[0].values())) if rows else default

    def execute(self, sql, parameters=()):
        with self.transaction() as connection:
            cursor = connection.cursor()
            cursor.execute(sql, parameters or None)
            return cursor.rowcount

    @contextlib.contextmanager
    def transaction(self):
        connection = self.connection()
        try:
            yield connection
            connection.commit()
        except BaseException:
            connection.rollback()
            raise
        finally:
            connection.close()

    def procedure(self, name, parameters=None, *, connection=None):
        if not all(part.replace('_', '').isalnum() for part in name.split('.')):
            raise ValueError('Invalid procedure identifier')
        values = parameters or {}
        if not all(key.replace('_', '').isalnum() for key in values):
            raise ValueError('Invalid procedure parameter')
        assignments = ', '.join('@' + key + '=%s' for key in values)
        owned = connection is None
        connection = connection or self.connection()
        try:
            cursor = connection.cursor()
            cursor.execute('EXEC ' + name + (' ' + assignments if assignments else ''), tuple(values.values()))
            sets = []
            while True:
                if cursor.description:
                    sets.append(cursor.fetchall())
                if not cursor.nextset():
                    break
            if owned:
                connection.commit()
            return sets
        except BaseException:
            if owned:
                connection.rollback()
            raise
        finally:
            if owned:
                connection.close()

    def call(self, name, values=None, *, connection=None):
        """Execute a recovered procedure, including its named OUTPUT parameters."""
        metadata = self.query(
            'SELECT p.name,TYPE_NAME(p.user_type_id) AS type,p.is_output '
            'FROM sys.parameters p WHERE p.object_id=OBJECT_ID(%s) ORDER BY parameter_id', (name,))
        if not metadata:
            raise DatabaseError('رویهٔ بانک پیدا نشد: ' + name)
        supplied = {key.lstrip('@').lower(): value for key, value in (values or {}).items()}
        expected = {p['name'][1:].lower() for p in metadata if not p['is_output']}
        unknown = set(supplied) - expected
        missing = expected - set(supplied)
        if unknown or missing:
            raise ValueError(f'{name}: missing={sorted(missing)}, unknown={sorted(unknown)}')
        declarations, assignments, inputs, outputs = [], [], [], []
        for index, item in enumerate(metadata):
            parameter = item['name']
            if item['is_output']:
                if item['type'] not in ('int', 'bigint', 'smallint', 'bit'):
                    raise DatabaseError('Unsupported output parameter type: ' + item['type'])
                local = f'@native_output_{index}'
                declarations.append(f'DECLARE {local} {item["type"]};')
                assignments.append(parameter + '=' + local + ' OUTPUT')
                outputs.append(local + ' AS [' + parameter[1:] + ']')
            else:
                assignments.append(parameter + '=%s')
                inputs.append(supplied[parameter[1:].lower()])
        statement = '\n'.join(declarations) + '\nEXEC ' + name + ' ' + ','.join(assignments) + ';'
        if outputs:
            statement += '\nSELECT ' + ','.join(outputs)
        owned = connection is None
        connection = connection or self.connection()
        try:
            cursor = connection.cursor()
            cursor.execute(statement, tuple(inputs) or None)
            results = []
            while True:
                if cursor.description:
                    results.append(cursor.fetchall())
                if not cursor.nextset():
                    break
            output = results.pop()[0] if outputs else {}
            if owned:
                connection.commit()
            return results, output
        except BaseException:
            if owned:
                connection.rollback()
            raise
        finally:
            if owned:
                connection.close()
