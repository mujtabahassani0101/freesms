from PySide6.QtGui import QColor, QPalette
from PySide6.QtWidgets import QColorDialog, QLabel, QSpinBox

from .base import Controller
from .students import ValidationError


class MainController(Controller):
    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.form.setWindowTitle('Free SMS — مدیریت مکتب')
        self.refresh()

    def refresh(self):
        for name, value in [('lYear', self.school.session.year), ('lUser', self.school.session.username), ('l_xschool', 'Free SMS')]:
            widget = self.widget(name)
            if isinstance(widget, QLabel):
                widget.setText(str(value))

    def handle(self, control):
        name = control.get('name')
        if name in ('toolSarbargReg', 'toolfrmRegisterPak0'):
            self.notify('نسخهٔ بومی بدون قفل سخت‌افزاری فعال است.')
            return True
        return False


class YearController(Controller):
    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        current = self.school.session.year
        rows = [{'id': year, 'name': str(year)} for year in range(min(1390, current), max(1410, current + 6))]
        self.combo('dropYear', rows, blank=False, selected=current)

    def handle(self, control):
        if control.get('name') == 'btnAcp':
            year = self.get('dropYear')
            if year is None:
                raise ValidationError('سال تعلیمی را انتخاب کنید.')
            self.school.set_year(year)
            self.changed()
            self.notify()
            return True
        return False


class TeacherAssignmentController(Controller):
    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.combo('comboPaye', self.school.choices('grades'), blank=False)
        self.combo('dropTch', self.school.choices('teachers'))
        self.combo('comboTypeFilter', [{'id': 'all', 'name': 'همه'}, {'id': 'cls', 'name': 'صنف'}, {'id': 'tch', 'name': 'معلم'}, {'id': 'both', 'name': 'صنف و معلم'}], blank=False)
        self.load_classes()
        self.widget('comboPaye').currentIndexChanged.connect(self.load_classes)
        self.widget('dropCls').currentIndexChanged.connect(self.load_books)
        self.widget('comboTypeFilter').currentIndexChanged.connect(self.refresh)
        self.widget('dropTch').currentIndexChanged.connect(self.refresh)
        self.refresh()

    def load_classes(self, *_):
        self.combo('dropCls', self.school.choices('classes', grade=self.get('comboPaye')), blank=False)
        self.load_books()

    def load_books(self, *_):
        assigned = {row['xLsn'] for row in self.school.teacher_assignments(self.get('dropCls'))} if self.get('dropCls') else set()
        self.combo('dropBook', [row for row in self.school.choices('books', grade=self.get('comboPaye')) if row['id'] not in assigned], blank=False)
        self.refresh()

    def refresh(self, *_):
        mode = self.get('comboTypeFilter')
        self.fill('gTchCls', self.school.teacher_assignments(
            self.get('dropCls') if mode in ('cls', 'both') else None,
            self.get('dropTch') if mode in ('tch', 'both') else None))

    def handle(self, control):
        name = control.get('name')
        if name == 'btnAdd':
            self.school.assign_teacher(self.get('dropCls'), self.get('dropBook'), self.get('dropTch'))
            self.load_books()
            self.changed()
        elif name == 'btnDelete':
            row = self.selected('gTchCls')
            if not row:
                raise ValidationError('یک مورد را انتخاب کنید.')
            if self.confirm('ارتباط معلم و درسِ انتخاب‌شده حذف شود؟'):
                self.school.unassign_teacher(row['xCls'], row['xLsn'])
                self.load_books()
                self.changed()
        else:
            return False
        return True


class ColorController(Controller):
    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        rows = self.db.query('SELECT TOP 1 R,G,B FROM tFormColor')
        for letter in 'RGB':
            widget = self.widget('txt' + letter)
            if isinstance(widget, QSpinBox):
                widget.setRange(0, 255)
                widget.setValue(rows[0][letter] if rows else 200)

    def handle(self, control):
        name = control.get('name')
        if name == 'btnNew':
            color = QColorDialog.getColor(parent=self.form, title='انتخاب رنگ')
            if color.isValid():
                for letter, value in zip('RGB', (color.red(), color.green(), color.blue())):
                    self.widget('txt' + letter).setValue(value)
        elif name == 'btnAcp':
            values = tuple(self.widget('txt' + letter).value() for letter in 'RGB')
            self.db.execute('UPDATE tFormColor SET R=%s,G=%s,B=%s', values)
            self.runtime.color = None
            self.runtime.apply_theme(self.form)
            self.changed()
            self.notify()
        else:
            return False
        return True
