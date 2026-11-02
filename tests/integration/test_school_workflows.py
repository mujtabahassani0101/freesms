"""Real SQL Server and Qt workflows in an isolated, disposable database."""
import dataclasses
import os
from pathlib import Path
import sys
import unittest
import uuid
from unittest.mock import patch

os.environ.setdefault('QT_QPA_PLATFORM', 'offscreen')
ROOT = Path(__file__).resolve().parents[2]
sys.path.insert(0, str(ROOT / 'native'))
from PySide6.QtWidgets import QApplication
from backend.database import Database, DatabaseConfig
from backend.entities import EntityService
from backend.migrations import decode_version, migrate
from backend.services import SchoolService, Session, ValidationError
from layout import BY_NAME, LegacyForm
from runtime import ApplicationRuntime


class SchoolWorkflows(unittest.TestCase):
    @classmethod
    def setUpClass(cls):
        cls.app = QApplication.instance() or QApplication([])
        cls.test_name = 'free_sms_test_' + uuid.uuid4().hex[:12]
        config = dataclasses.replace(DatabaseConfig.default(), database=cls.test_name)
        cls.db = Database(config).ensure_database()
        migrate(cls.db)
        cls.service = SchoolService(cls.db, Session(year=1410))
        cls.entities = EntityService(cls.service)
        cls.serial = 50000

    @classmethod
    def tearDownClass(cls):
        assert cls.test_name.startswith('free_sms_test_')
        with cls.db.connection('master', autocommit=True) as connection:
            cursor = connection.cursor()
            cursor.execute(f'ALTER DATABASE [{cls.test_name}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE [{cls.test_name}]')

    def classroom(self):
        type(self).serial += 1
        serial = type(self).serial
        return self.service.save_class({'name': 'صنف آزمون ' + str(serial), 'xpaye': 1, 'fee': 1000, 'shift': 1, 'sortRpt': serial - 30000})

    def record(self):
        classroom = self.classroom()
        return {'FName': 'احمد', 'LName': 'حسین', 'PName': 'کریم', 'xPaye': 1,
            'xClass': classroom, 'Code': self.serial, 'NumberAsas': self.serial,
            'Status': 1, 'Jens': 1, 'Fee1': 1200, 'Fee2': 500, 'transport1': 100,
            'LastName': "احمدی ' آزمایش", 'MobileFather': '0701234567'}

    def test_migrations_are_complete_and_idempotent(self):
        before = self.db.scalar('SELECT COUNT(*) AS n FROM native_migrations')
        migrate(self.db)
        self.assertEqual(before, self.db.scalar('SELECT COUNT(*) AS n FROM native_migrations'))
        self.assertEqual('1402/11/19', decode_version(self.db.scalar('SELECT ver FROM tVer')))
        self.assertEqual(53, self.db.scalar('SELECT COUNT(*) AS n FROM sys.tables'))
        self.assertIsNotNone(self.db.scalar("SELECT COL_LENGTH('tStudent','En_LastName') AS n"))

    def test_register_update_search_duplicates_and_delete(self):
        values = self.record()
        identifier = self.service.save_student(values)
        saved = self.service.student(identifier)
        self.assertEqual("احمدی ' آزمایش", saved['LastName'])
        self.assertEqual(1700, saved['SumFee'])
        self.assertEqual(100, saved['Sumtransport'])
        self.assertTrue(saved['hazer'])
        self.assertEqual(identifier, self.service.students({'code': values['Code']})[0]['id'])
        values['Fee1'], values['Fee2'] = 900, 10
        self.assertEqual(identifier, self.service.save_student(values, identifier))
        self.assertEqual(910, self.service.student(identifier)['SumFee'])
        with self.assertRaisesRegex(ValidationError, 'کد متعلم تکراری'):
            self.service.save_student(values)
        other = dict(values, Code=values['Code'] + 1000000)
        with self.assertRaisesRegex(ValidationError, 'نمبر اساس تکراری'):
            self.service.save_student(other)
        with self.assertRaises(ValidationError):
            self.service.delete_class(values['xClass'])
        self.service.delete_student(identifier)
        self.assertIsNone(self.service.student(identifier))
        self.service.delete_class(values['xClass'])

    def test_student_image_is_saved_in_registration_transaction(self):
        values = self.record()
        image = (ROOT / 'native/assets/asdat_btnAcp_Image.png').read_bytes()
        values['Student_img'] = image
        identifier = self.service.save_student(values)
        self.assertEqual(image, self.db.scalar('SELECT Student_img FROM tStudentImg WHERE xStudent=%s', (identifier,)))

    def test_reference_crud_and_reference_protection(self):
        teacher = self.entities.save('teachers', {'fNamF': 'محمد', 'fNamL': 'حسینی', 'fEmail': '', 'fPassword': ''})
        self.entities.save('teachers', {'fNamF': 'محمدرضا', 'fNamL': 'حسینی'}, teacher)
        self.assertEqual('محمدرضا', self.db.scalar('SELECT fNamF FROM tTeacher WHERE id=%s', (teacher,)))
        discount = self.entities.save('discounts', {'name': 'تخفیف آزمون', 'comment': 'ثبت آزمایشی'})
        values = self.record()
        values['xTakhfif'] = discount
        self.service.save_student(values)
        with self.assertRaises(ValidationError):
            self.entities.delete('discounts', discount)
        self.entities.delete('teachers', teacher)

    def test_year_creates_three_terms_and_assignments_validate_grade(self):
        previous = self.service.session.year
        try:
            self.service.set_year(1411)
            exams = self.db.query('SELECT term FROM tExam WHERE xYear=%s ORDER BY term', (1411,))
            self.assertEqual([1, 2, 3], [row['term'] for row in exams])
            self.service.set_year(1411)
            self.assertEqual(3, self.db.scalar('SELECT COUNT(*) AS n FROM tExam WHERE xYear=1411'))
            classroom = self.classroom()
            teacher = self.entities.save('teachers', {'fNamF': 'استاد', 'fNamL': 'آزمون'})
            book = self.entities.save('books', {'xPaye': 1, 'Name': 'ریاضی آزمون', 'vahed': 1, 'timeWeek': 1, 'Type': 1, 'sort': 1, 'SortOneEntry': 1, 'codedars': self.serial, 'Vezarat': True})
            self.service.assign_teacher(classroom, book, teacher)
            self.assertEqual(teacher, self.service.teacher_assignments(classroom)[0]['xTch'])
            with self.assertRaises(ValidationError):
                self.service.assign_teacher(classroom, book, teacher)
            with self.assertRaises(ValidationError):
                self.entities.delete('teachers', teacher)
            self.service.unassign_teacher(classroom, book)
            self.entities.delete('teachers', teacher)
        finally:
            self.service.set_year(previous)

    def test_qt_school_save_and_registration_button(self):
        runtime = ApplicationRuntime(self.db, Session(year=1410))
        school = LegacyForm(BY_NAME['frmSchool'], preview=False, runtime=runtime)
        school.controller.put('txtSch', 'مکتب آزمون بومی')
        school.controller.put('txtOst', 'کابل')
        school.controller.widget('btnAcp').click()
        self.assertEqual('مکتب آزمون بومی', self.service.school()['sch'])
        classroom = self.classroom()
        with patch('PySide6.QtWidgets.QMessageBox.warning', side_effect=lambda *args: self.fail(str(args[2]))):
            student = LegacyForm(BY_NAME['frmSabtenam'], preview=False, runtime=runtime)
            c = student.controller
            for field, value in [('txtNamF', 'فاطمه'), ('txtNamL', 'علی'), ('dropPaye', 1),
                    ('dropCls', classroom), ('txtCode', self.serial), ('txtNumberAsas', self.serial), ('txtFee1', 700)]:
                c.put(field, value)
            c.widget('btnAcp').click()
            self.assertGreater(c.identifier, 0)
            self.assertEqual(700, self.service.student(c.identifier)['SumFee'])
            self.assertEqual('فاطمه', self.service.student(c.identifier)['FName'])
            student.close()
        school.close()


if __name__ == '__main__':
    unittest.main(verbosity=2)
