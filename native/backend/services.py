from __future__ import annotations

import dataclasses
import datetime
from typing import Any

from .database import Database, DatabaseError


class ValidationError(ValueError):
    pass


def normalize_text(value):
    return str(value or '').strip().replace('ي', 'ی').replace('ك', 'ک')


def number(value, *, nullable=True, minimum=None, maximum=None):
    if value is None or str(value).strip() == '':
        if nullable:
            return None
        return 0
    try:
        result = int(str(value).translate(str.maketrans('۰۱۲۳۴۵۶۷۸۹٠١٢٣٤٥٦٧٨٩', '01234567890123456789')))
    except (TypeError, ValueError):
        raise ValidationError('مقدار عددی معتبر وارد کنید.')
    if minimum is not None and result < minimum:
        raise ValidationError(f'مقدار باید دست‌کم {minimum} باشد.')
    if maximum is not None and result > maximum:
        raise ValidationError(f'مقدار باید حداکثر {maximum} باشد.')
    return result


@dataclasses.dataclass
class Session:
    year: int = 1398
    user_id: int = 1
    username: str = 'admin'


class SchoolService:
    def __init__(self, database: Database, session: Session | None = None):
        self.db = database
        self.session = session or Session(year=int(database.scalar('SELECT TOP 1 xyear FROM tDefYear', default=1398)))

    def school(self):
        rows = self.db.query('SELECT TOP 1 * FROM tParmetr')
        return rows[0] if rows else {}

    def save_school(self, values):
        fields = ('Ost', 'cty', 'sch', 'Foter1')
        if not normalize_text(values.get('sch')):
            raise ValidationError('نام مکتب را وارد کنید.')
        with self.db.transaction() as connection:
            cursor = connection.cursor()
            cursor.execute('SELECT COUNT(*) AS n FROM tParmetr')
            if cursor.fetchone()['n']:
                cursor.execute('UPDATE tParmetr SET Ost=%s,cty=%s,sch=%s,Foter1=%s', tuple(normalize_text(values.get(k)) for k in fields))
            else:
                cursor.execute('INSERT INTO tParmetr(Ost,cty,sch,Foter1) VALUES (%s,%s,%s,%s)', tuple(normalize_text(values.get(k)) for k in fields))

    def choices(self, table, *, year=None, grade=None, parent=None):
        queries = {
            'grades': ('SELECT id,Name AS name,xMaghta FROM tPaye ORDER BY id', ()),
            'levels': ('SELECT id,name FROM tMaghta ORDER BY id', ()),
            'classes': ('SELECT id,name,xpaye FROM tClass WHERE xYear=%s' + (' AND xpaye=%s' if grade else '') + ' ORDER BY sortRpt,id', (year or self.session.year,) + ((grade,) if grade else ())),
            'teachers': ("SELECT id,fNamF+N' '+fNamL AS name FROM tTeacher ORDER BY fNamL,fNamF", ()),
            'books': ('SELECT id,Name AS name,xPaye,vahed FROM tBook' + (' WHERE xPaye=%s' if grade else '') + ' ORDER BY sort,id', ((grade,) if grade else ())),
            'drivers': ('SELECT id,name FROM tDriver ORDER BY name', ()),
            'discounts': ('SELECT id,name FROM tTakhfif ORDER BY name', ()),
            'provinces': ('SELECT id,Name AS name FROM tOstan ORDER BY Name', ()),
            'cities': ('SELECT id,Name AS name,xOstan FROM tCity' + (' WHERE xOstan=%s' if parent else '') + ' ORDER BY Name', ((parent,) if parent else ())),
            'exams': ('SELECT id,Name AS name,term FROM tExam WHERE xYear=%s ORDER BY NumExam,id', (year or self.session.year,)),
            'students': ("SELECT s.id,s.FName+N' '+ISNULL(s.LastName,N'')+N' / '+s.LName AS name FROM tStudent s JOIN tYear_Student y ON y.xStudent=s.id WHERE y.xYear=%s ORDER BY s.FName,s.LName", (year or self.session.year,)),
        }
        if table not in queries:
            raise ValueError('Unknown choice source: ' + table)
        return self.db.query(*queries[table])

    def classes(self):
        return self.db.query("""SELECT c.*,p.Name AS Paye,
            CASE c.shift WHEN 1 THEN N'صبح' WHEN 2 THEN N'عصر' END AS shifttext
            FROM tClass c JOIN tPaye p ON p.id=c.xpaye WHERE c.xYear=%s ORDER BY c.sortRpt,c.id""", (self.session.year,))

    def save_class(self, values, identifier=0):
        name = normalize_text(values.get('name'))
        grade = number(values.get('xpaye'))
        if not name or grade is None:
            raise ValidationError('نام صنف و پایه را مشخص کنید.')
        _, out = self.db.call('sp_tClass_insertUpdate', {
            'id': identifier, 'xYear': self.session.year, 'xpaye': grade, 'name': name,
            'answerable': normalize_text(values.get('answerable')), 'fee': number(values.get('fee'), nullable=False, minimum=0),
            'shift': number(values.get('shift'), nullable=False), 'sortRpt': number(values.get('sortRpt'), nullable=False, minimum=0, maximum=32767),
        })
        code = out.get('code')
        if code is not None and code < 0:
            raise ValidationError('نام صنف تکراری است.' if code == -100 else 'ترتیب نمایش صنف تکراری است.')
        return identifier or self.db.scalar("SELECT id FROM tClass WHERE xYear=%s AND REPLACE(name,N' ',N'')=REPLACE(%s,N' ',N'')", (self.session.year, name))

    def students(self, filters=None):
        filters = filters or {}
        where = ['y.xYear=%s']
        parameters = [self.session.year]
        for key, column in [('grade', 'y.xPaye'), ('class', 'y.xClass'), ('status', 'y.Status'), ('gender', 's.Jens'), ('code', 's.Code'), ('number_asas', 's.NumberAsas'), ('discount_code', 'y.codeTakhfif')]:
            if filters.get(key) not in (None, ''):
                where.append(column + '=%s')
                parameters.append(number(filters[key]))
        for key, column in [('first_name', 's.FName'), ('father_name', 's.LName'), ('last_name', 's.LastName')]:
            if normalize_text(filters.get(key)):
                where.append(column + ' LIKE %s')
                parameters.append('%' + normalize_text(filters[key]) + '%')
        return self.db.query("""SELECT s.id,s.Code,s.FName,s.LName,s.PName,s.LastName,s.NumberAsas,s.bDate,s.Jens,
            s.MobileFather,s.MobileMother,s.NumberTelegram,y.Status,y.xClass,y.xPaye,
            c.name AS class,p.Name AS Paye,y.xYear,y.SumFee,y.Sumtransport,y.xTakhfif,
            y.xDriver,y.codeTakhfif,y.shaghe,y.hazer,y.mali
            FROM tStudent s JOIN tYear_Student y ON y.xStudent=s.id
            LEFT JOIN tClass c ON c.id=y.xClass LEFT JOIN tPaye p ON p.id=y.xPaye WHERE """ +
            ' AND '.join(where) + ' ORDER BY s.FName,s.LName,s.id', tuple(parameters))

    def student(self, identifier):
        rows = self.db.query('SELECT s.*,y.* FROM tStudent s JOIN tYear_Student y ON y.xStudent=s.id WHERE s.id=%s AND y.xYear=%s', (identifier, self.session.year))
        if not rows:
            return None
        row = rows[0]
        row['id'] = identifier  # Enrollment and student have separate identity columns.
        return row

    def save_student(self, values, identifier=0):
        data = dict(values)
        if not normalize_text(data.get('FName')):
            raise ValidationError('نام شاگرد را وارد کنید.')
        if not normalize_text(data.get('LName')):
            raise ValidationError('ولد / بنت را وارد کنید.')
        grade, classroom = number(data.get('xPaye')), number(data.get('xClass'))
        if grade is None or classroom is None:
            raise ValidationError('پایه و صنف شاگرد را مشخص کنید.')
        actual = self.db.query('SELECT xpaye FROM tClass WHERE id=%s AND xYear=%s', (classroom, self.session.year))
        if not actual or actual[0]['xpaye'] != grade:
            raise ValidationError('صنف انتخاب‌شده با پایه و سال تعلیمی مطابقت ندارد.')
        fields = self.db.query("SELECT p.name,TYPE_NAME(p.user_type_id) AS type FROM sys.parameters p WHERE p.object_id=OBJECT_ID('sp_tStudent_insertUpdate') AND p.is_output=0 ORDER BY parameter_id")
        lookup = {key.lower(): value for key, value in data.items()}
        inputs = {}
        for field in fields:
            key = field['name'][1:]
            value = lookup.get(key.lower())
            if key.lower() == 'id':
                value = identifier
            elif key.lower() == 'xyear':
                value = self.session.year
            elif field['type'] == 'bit':
                value = bool(value) if value is not None else key.lower() in ('shaghe', 'hazer', 'mali')
            elif field['type'] in ('int', 'bigint', 'smallint'):
                value = number(value)
                if key.lower().startswith(('fee', 'transport')) and value is None:
                    value = 0
            elif field['type'] in ('nvarchar', 'varchar'):
                value = normalize_text(value) or None
            inputs[key] = value
        for prefix, total in [('Fee', 'SumFee'), ('transport', 'Sumtransport')]:
            inputs[total] = sum(inputs.get(prefix + str(i)) or 0 for i in range(1, 10))
            if any((inputs.get(prefix + str(i)) or 0) < 0 for i in range(1, 10)):
                raise ValidationError('مبلغ فیس و ترانسپورت نمی‌تواند منفی باشد.')
        inputs['xPaye'], inputs['xClass'] = grade, classroom
        with self.db.transaction() as connection:
            _, out = self.db.call('sp_tStudent_insertUpdate', inputs, connection=connection)
            code = out['CodeOut']
            if code == -100:
                raise ValidationError('کد متعلم تکراری است.')
            if code == -200:
                raise ValidationError('نمبر اساس تکراری است.')
            code = identifier or code
            if code is None or code <= 0:
                raise DatabaseError('شناسهٔ شاگرد از بانک دریافت نشد.')
            cursor = connection.cursor()
            cursor.execute('UPDATE tExam SET procc=0 WHERE xYear=%s', (self.session.year,))
            if 'Student_img' in data:
                self.db.call('sp_tStudentImg_InsertUpdate', {'id': code, 'img': data['Student_img']}, connection=connection)
        return code

    def save_student_image(self, identifier, image):
        self.db.call('sp_tStudentImg_InsertUpdate', {'id': identifier, 'img': image})

    def delete_class(self, identifier):
        if self.db.scalar('SELECT COUNT(*) AS n FROM tYear_Student WHERE xClass=%s', (identifier,)):
            raise ValidationError('این صنف شاگرد دارد و قابل حذف نیست.')
        self.db.execute('DELETE FROM tClass WHERE id=%s AND xYear=%s', (identifier, self.session.year))

    def delete_student(self, identifier):
        # The original list deletes the entire record, not just its enrollment.
        with self.db.transaction() as connection:
            cursor = connection.cursor()
            cursor.execute('UPDATE tExam SET procc=0 WHERE id IN (SELECT Xtest FROM tMarkDoreh WHERE xStudent=%s)', (identifier,))
            for table in ('tPaymentStudent', 'tMark', 'tMarkDoreh', 'tMarkAgo', 'tHazeriAgo', 'tEnzebat', 'tComnentKarname', 'tComnentStd', 'tStudentImg', 'tYear_Student'):
                cursor.execute('DELETE FROM [' + table + '] WHERE xStudent=%s', (identifier,))
            cursor.execute('DELETE FROM tStudent WHERE id=%s', (identifier,))


    def set_year(self, year):
        year = number(year, nullable=False, minimum=1300, maximum=1600)
        self.db.call('Sp_SetDefYear', {'xYear': year})
        self.session.year = year
        return year

    def teacher_assignments(self, classroom=None, teacher=None):
        where, params = ['c.xYear=%s'], [self.session.year]
        if classroom:
            where.append('a.xCls=%s')
            params.append(classroom)
        if teacher:
            where.append('a.xTch=%s')
            params.append(teacher)
        return self.db.query("SELECT a.xCls,a.xLsn,a.xTch,t.fNamF+N' '+t.fNamL AS tch,"
            "b.Name AS lsn,p.Name AS Paye,c.name AS cls FROM tTch_Cls a "
            "JOIN tTeacher t ON t.id=a.xTch JOIN tBook b ON b.id=a.xLsn "
            "JOIN tPaye p ON p.id=b.xPaye JOIN tClass c ON c.id=a.xCls WHERE " +
            ' AND '.join(where) + ' ORDER BY p.id,c.id,b.sort', tuple(params))

    def assign_teacher(self, classroom, book, teacher):
        classroom, book, teacher = number(classroom), number(book), number(teacher)
        if None in (classroom, book, teacher):
            raise ValidationError('صنف، درس و معلم را انتخاب کنید.')
        if not self.db.scalar('SELECT COUNT(*) AS n FROM tClass c JOIN tBook b ON b.xPaye=c.xpaye WHERE c.id=%s AND b.id=%s AND c.xYear=%s', (classroom, book, self.session.year)):
            raise ValidationError('درس با پایهٔ صنف مطابقت ندارد.')
        if not self.db.scalar('SELECT COUNT(*) AS n FROM tTeacher WHERE id=%s', (teacher,)):
            raise ValidationError('معلم انتخاب‌شده موجود نیست.')
        if self.db.scalar('SELECT COUNT(*) AS n FROM tTch_Cls WHERE xCls=%s AND xLsn=%s', (classroom, book)):
            raise ValidationError('برای این درس و صنف قبلاً معلم تعیین شده است.')
        self.db.execute('INSERT INTO tTch_Cls(xCls,xLsn,xTch) VALUES (%s,%s,%s)', (classroom, book, teacher))

    def unassign_teacher(self, classroom, book):
        self.db.execute('DELETE FROM tTch_Cls WHERE xCls=%s AND xLsn=%s', (classroom, book))
