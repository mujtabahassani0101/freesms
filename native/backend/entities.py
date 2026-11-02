"""CRUD for source-observed reference-data forms, with reference checks."""
from __future__ import annotations

import dataclasses

from .services import SchoolService, ValidationError, normalize_text, number


@dataclasses.dataclass(frozen=True)
class Entity:
    table: str
    fields: tuple[str, ...]
    required: tuple[str, ...] = ()
    year: bool = False
    references: tuple[tuple[str, str], ...] = ()


ENTITIES = {
    'grades': Entity('tPaye', ('Name', 'xMaghta'), ('Name',), references=(('tClass', 'xpaye'), ('tYear_Student', 'xPaye'), ('tBook', 'xPaye'))),
    'teachers': Entity('tTeacher', ('fNamF', 'fNamL', 'fEmail', 'fPassword'), ('fNamF', 'fNamL'), references=(('tTch_Cls', 'xTch'),)),
    'drivers': Entity('tDriver', ('name', 'mobil', 'mobil2', 'comment'), ('name',), references=(('tYear_Student', 'xDriver'),)),
    'books': Entity('tBook', ('xPaye', 'Name', 'vahed', 'timeWeek', 'Type', 'sort', 'SortOneEntry', 'codedars', 'Vezarat'), ('Name', 'xPaye'), references=(('tMark', 'xbook'), ('tMarkAgo', 'xbook'), ('tTch_Cls', 'xLsn'))),
    'discounts': Entity('tTakhfif', ('name', 'comment'), ('name',), references=(('tYear_Student', 'xTakhfif'),)),
    'exams': Entity('tExam', ('Name', 'NumExam', 'DateFrom', 'DateTo', 'term', 'procc'), ('Name',), year=True, references=(('tMark', 'Xtest'), ('tComnentKarname', 'Xtest'), ('tMarkDoreh', 'Xtest'))),
    'year_days': Entity('tYearMaghtaCountDay', ('xMaghta', 'Term1', 'Term2'), ('xMaghta',), year=True),
    'halls': Entity('tHozeh', ('Name', 'Capacity'), ('Name',)),
    'provinces': Entity('tOstan', ('Name',), ('Name',), references=(('tCity', 'xOstan'),)),
    'cities': Entity('tCity', ('xOstan', 'Name'), ('Name', 'xOstan'), references=(('tStudent', 'xCity'), ('tStudent', 'xCityNow'))),
    'grading': Entity('tTosif', ('fromMark', 'toMark', 'tosif', 'tosifM', 'term', 'lev', 'comment'), ('tosif',)),
}


class EntityService:
    def __init__(self, school: SchoolService):
        self.school = school
        self.db = school.db

    def list(self, entity, *, filters=None):
        spec = ENTITIES[entity]
        where, parameters = [], []
        if spec.year:
            where.append('xYear=%s')
            parameters.append(self.school.session.year)
        if entity == 'exams':
            where.append('term=0')
        for key, value in (filters or {}).items():
            if key not in spec.fields:
                raise ValueError('Unknown entity field')
            where.append('[' + key + ']=%s')
            parameters.append(value)
        sql = 'SELECT * FROM [' + spec.table + ']'
        if where:
            sql += ' WHERE ' + ' AND '.join(where)
        sql += ' ORDER BY id'
        return self.db.query(sql, tuple(parameters))

    def save(self, entity, values, identifier=0):
        spec = ENTITIES[entity]
        metadata = self.db.query('SELECT c.name,TYPE_NAME(c.user_type_id) AS type,c.is_identity FROM sys.columns c WHERE c.object_id=OBJECT_ID(%s)', (spec.table,))
        columns = {column['name'].lower(): column for column in metadata}
        submitted = {key.lower(): value for key, value in values.items()}
        data = {}
        for field in spec.fields:
            if field.lower() not in submitted:
                continue
            value = submitted[field.lower()]
            kind = columns[field.lower()]['type']
            if kind in ('int', 'smallint', 'bigint', 'tinyint'):
                value = number(value)
            elif kind in ('float', 'real', 'decimal', 'numeric'):
                try:
                    value = float(value) if value not in (None, '') else None
                except (ValueError, TypeError):
                    raise ValidationError('مقدار عددی معتبر وارد کنید.')
            elif kind == 'bit':
                value = bool(value)
            else:
                value = normalize_text(value)
            data[field] = value
        for field in spec.required:
            if data.get(field) in (None, ''):
                raise ValidationError('فیلدهای الزامی را تکمیل کنید.')
        if spec.year:
            data['xYear'] = self.school.session.year
        if entity == 'exams':
            data.update(term=0, procc=0)
        if entity == 'year_days':
            if any((data.get(field) or 0) < 0 for field in ('Term1', 'Term2')):
                raise ValidationError('تعداد ایام نمی‌تواند منفی باشد.')
            if self.db.scalar('SELECT COUNT(*) AS n FROM tYearMaghtaCountDay WHERE xYear=%s AND xMaghta=%s AND id<>%s',
                    (self.school.session.year, data['xMaghta'], identifier)):
                raise ValidationError('ایام این مقطع قبلاً ثبت شده است.')
        if entity == 'books':
            if self.db.scalar('SELECT COUNT(*) AS n FROM tBook WHERE xPaye=%s AND id<>%s AND (Name=%s OR codedars=%s)',
                    (data['xPaye'], identifier, data['Name'], data.get('codedars'))):
                raise ValidationError('نام یا کد درس در این پایه تکراری است.')
        with self.db.transaction() as connection:
            cursor = connection.cursor()
            if identifier:
                cursor.execute('UPDATE [' + spec.table + '] SET ' + ','.join('[' + key + ']=%s' for key in data) + ' WHERE id=%s', tuple(data.values()) + (identifier,))
                if cursor.rowcount != 1:
                    raise ValidationError('رکورد انتخاب‌شده دیگر موجود نیست.')
            else:
                if not columns['id']['is_identity']:
                    if submitted.get('id') not in (None, ''):
                        identifier = number(submitted['id'])
                    else:
                        start = 10000 if entity == 'teachers' else 101 if entity == 'exams' else 1
                        cursor.execute('SELECT ISNULL(MAX(id)+1,%s) AS id FROM [' + spec.table + '] WITH (UPDLOCK,HOLDLOCK)', (start,))
                        identifier = cursor.fetchone()['id']
                    data['id'] = identifier
                cursor.execute('INSERT INTO [' + spec.table + '] (' + ','.join('[' + key + ']' for key in data) + ') OUTPUT INSERTED.id VALUES (' + ','.join('%s' for _ in data) + ')', tuple(data.values()))
                identifier = cursor.fetchone()['id']
            if entity == 'books':
                cursor.execute('UPDATE tExam SET procc=0 WHERE xYear=%s', (self.school.session.year,))
        return identifier

    def delete(self, entity, identifier):
        spec = ENTITIES[entity]
        with self.db.transaction() as connection:
            cursor = connection.cursor()
            for table, field in spec.references:
                cursor.execute('SELECT COUNT(*) AS n FROM [' + table + '] WHERE [' + field + ']=%s', (identifier,))
                if cursor.fetchone()['n']:
                    raise ValidationError('این رکورد در اطلاعات دیگر استفاده شده و قابل حذف نیست.')
            if entity == 'halls':
                cursor.execute('UPDATE tYear_Student SET xHozeh=NULL,idx=NULL WHERE xHozeh=%s', (identifier,))
            cursor.execute('DELETE FROM [' + spec.table + '] WHERE id=%s', (identifier,))
