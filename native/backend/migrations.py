"""Apply the original SQL upgrades in version order, atomically per script."""
from __future__ import annotations

import base64
import hashlib
import json
import re
from pathlib import Path

from .database import Database, DatabaseError, PROJECT


def decode_version(value):
    if not value:
        return '0000/00/00'
    for encoding in ('ascii', 'utf-16-le', 'utf-7', 'utf-8'):
        value = base64.b64decode(value).decode(encoding)
    return value


def encode_version(value):
    for encoding in ('utf-8', 'utf-7', 'utf-16-le', 'ascii'):
        value = base64.b64encode(value.encode(encoding)).decode('ascii')
    return value


def migration_version(resource):
    number = re.search(r'\d+', resource)[0]
    number = '13' + number if len(number) == 6 else number
    return number[:4] + '/' + number[4:6] + '/' + number[6:8]


def batches(source):
    return [part.strip() for part in re.split(r'^\s*GO\s*(?:--[^\n]*)?$', source, flags=re.M | re.I) if part.strip()]


def migrate(database: Database, progress=None):
    database.execute("""IF OBJECT_ID('dbo.native_migrations') IS NULL
        CREATE TABLE dbo.native_migrations (
            version varchar(20) NOT NULL PRIMARY KEY,
            sha256 char(64) NOT NULL,
            applied_at datetime2 NOT NULL DEFAULT SYSUTCDATETIME()
        )""")
    current = decode_version(database.scalar('SELECT TOP 1 ver FROM tVer'))
    index = json.loads((PROJECT / 'analysis/sql-resources/index.json').read_text(encoding='utf-8'))
    scripts = sorted(index, key=lambda item: migration_version(item['resource']))
    for script in scripts:
        version = migration_version(script['resource'])
        if version <= current:
            continue
        text = (PROJECT / script['file']).read_text(encoding='utf-8')
        digest = hashlib.sha256(text.encode()).hexdigest()
        if digest != script['sha256']:
            raise DatabaseError('اسکریپت به‌روزرسانی بانک تغییر کرده است: ' + version)
        if progress:
            progress('به‌روزرسانی بانک: ' + version)
        try:
            with database.transaction() as connection:
                cursor = connection.cursor()
                for number, batch in enumerate(batches(text), 1):
                    cursor.execute(batch)
                    while cursor.nextset():
                        pass
                cursor.execute('INSERT INTO native_migrations(version,sha256) VALUES (%s,%s)', (version, digest))
        except Exception as error:
            raise DatabaseError(f'به‌روزرسانی {version}، بخش {number}: {error}') from error
        current = version
    # These files are populated by the original updater outside its SQL resources.
    if database.scalar("SELECT OBJECT_ID('dbo.tRptDynamic') AS id"):
        captions = {1: 'سربرگ امتحانی - پیش فرض', 2: 'سربرگ امتحانی چند صفحه ای - پیش فرض',
            3: 'دعوت نامه - پیش فرض', 4: 'فرم - پیش فرض', 5: 'کارت ورود به جلسه - پیش فرض',
            6: 'کارت تبریک تولد - پیش فرض', 40: 'کارت امتحان - پیش فرض'}
        for identifier, caption in captions.items():
            path = PROJECT / f'original/update/rpt/{identifier}.rpx'
            if not path.exists():
                continue
            if database.scalar('SELECT COUNT(*) AS n FROM tRptDynamic WHERE id=%s', (identifier,)) == 0:
                database.execute('INSERT INTO tRptDynamic(id,Caption,Rpt,sys,type) VALUES (%s,%s,%s,1,%s)',
                    (identifier, caption, path.read_bytes(), identifier if identifier < 7 else 4))
    # Later original updater functions only advance tVer to this executable version.
    database.execute('UPDATE tVer SET ver=%s', (encode_version('1402/11/19'),))
    return '1402/11/19'
