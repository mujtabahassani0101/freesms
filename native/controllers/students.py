from pathlib import Path

from PySide6.QtCore import Qt
from PySide6.QtGui import QPixmap
from PySide6.QtWidgets import QComboBox, QFileDialog, QLineEdit, QTableWidget

from backend.services import ValidationError, number
from .base import Controller


STUDENT_FIELDS = {
    'txtCode': 'Code', 'txtNamF': 'FName', 'txtNamL': 'LName', 'txtNamP': 'PName',
    'txtLastName': 'LastName', 'txtEn_Fname': 'En_Fname', 'txtEn_Lname': 'En_Lname',
    'txtEn_LastName': 'En_LastName', 'txtSh_sh': 'Sh_Sh', 'txtbDate': 'bDate', 'txtbDateM': 'bDateM',
    'txtMobileFather': 'MobileFather', 'txtMobileMother': 'MobileMother', 'txtNumberTelegram': 'NumberTelegram',
    'dropJens': 'Jens', 'dropMazhab': 'Mazhab', 'txtNumberAsas': 'NumberAsas',
    'txtRegDate': 'RegDate', 'txtAdress': 'Adress', 'txtExitDate': 'ExitDate', 'dropStatus': 'Status',
    'dropPaye': 'xPaye', 'dropCls': 'xClass', 'dropDriver': 'xDriver', 'comboTakhfif': 'xTakhfif',
    'dropcity': 'xcity', 'dropcityNow': 'xCityNow', 'txtcodeTakhfif': 'codeTakhfif',
    'checkshaghe': 'shaghe', 'checkhazer': 'hazer', 'checkmali': 'mali', 'checkdakhle': 'dakhle',
    'checkuniform': 'uniform', 'checkkomakdarsi': 'komakdarsi', 'checkketab': 'ketab',
    'checktransport': 'transport', 'checkrobotic': 'robotic', 'checkmaghnae': 'maghnae',
    'checkMarkTerm3_From100': 'MarkTerm3_From100',
    **{'txtFee' + str(i): 'Fee' + str(i) for i in range(1, 10)},
    **{'txttransport' + str(i): 'transport' + str(i) for i in range(1, 10)},
}
STATUS = [{'id': 1, 'name': 'برحال'}, {'id': 2, 'name': 'محروم'}, {'id': 3, 'name': 'منفک'}, {'id': 4, 'name': 'معذرتی'}]
GENDER = [{'id': 1, 'name': 'مرد'}, {'id': 0, 'name': 'زن'}]


class StudentListController(Controller):
    filters = {'txtFName': 'first_name', 'txtLName': 'father_name', 'txtCode': 'code',
        'txtNumberAsas': 'number_asas', 'txtCodeTakhfif': 'discount_code',
        'dropPaye': 'grade', 'dropCls': 'class', 'dropStatus': 'status', 'dropJens': 'gender'}

    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.combo('dropPaye', self.school.choices('grades'))
        self.combo('dropStatus', STATUS)
        self.combo('dropJens', GENDER)
        self.load_classes()
        for name in self.filters:
            widget = self.widget(name)
            if isinstance(widget, QLineEdit):
                widget.textChanged.connect(self.refresh)
            elif isinstance(widget, QComboBox):
                widget.currentIndexChanged.connect(self.load_classes if name == 'dropPaye' else self.refresh)
        table = self.widget('gridEX1')
        if isinstance(table, QTableWidget):
            table.cellDoubleClicked.connect(lambda *_: self.open_selected())
        self.refresh()

    def load_classes(self, *_):
        self.combo('dropCls', self.school.choices('classes', grade=self.get('dropPaye')))
        self.refresh()

    def refresh(self, *_):
        filters = {key: self.get(name) for name, key in self.filters.items()}
        self.fill('gridEX1', self.school.students(filters))

    def open_selected(self):
        row = self.selected('gridEX1')
        if not row:
            raise ValidationError('یک شاگرد را انتخاب کنید.')
        self.runtime.open('frmSabtenam', parent=self.form, context={'student_id': row['id']})

    def handle(self, control):
        name = control.get('name', '').lower()
        if name == 'btnnew':
            self.runtime.open('frmSabtenam', parent=self.form)
        elif name == 'btnedit':
            self.open_selected()
        elif name in ('btndelete', 'btndeletestd'):
            row = self.selected('gridEX1')
            if not row:
                raise ValidationError('یک شاگرد را انتخاب کنید.')
            if self.confirm('پرونده، نمرات و پرداخت‌های شاگرد انتخاب‌شده به‌طور کامل حذف شود؟'):
                self.school.delete_student(row['id'])
                self.refresh()
                self.changed()
        elif name == 'btnnosearch':
            for name in self.filters:
                self.put(name, None)
            self.refresh()
        else:
            return False
        return True


class StudentController(Controller):
    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.identifier = self.context.get('student_id', 0)
        self.image_changed = False
        self.image = None
        self.combo('dropPaye', self.school.choices('grades'), blank=False)
        self.combo('dropStatus', STATUS, blank=False)
        self.combo('dropJens', GENDER)
        self.combo('dropMazhab', [{'id': 1, 'name': 'شیعه'}, {'id': 2, 'name': 'سنی'}])
        for widget, source in [('dropDriver', 'drivers'), ('comboTakhfif', 'discounts'), ('dropcity', 'cities'), ('dropcityNow', 'cities')]:
            self.combo(widget, self.school.choices(source))
        self.load_classes()
        self.widget('dropPaye').currentIndexChanged.connect(self.load_classes)
        self.widget('dropCls').currentIndexChanged.connect(self.class_fee)
        for i in range(1, 10):
            for prefix in ('txtFee', 'txttransport'):
                widget = self.widget(prefix + str(i))
                if widget:
                    widget.textChanged.connect(self.totals)
        for name in ('txtSumFee', 'txtSumtransport', 'txtFeeClass'):
            widget = self.widget(name)
            if isinstance(widget, QLineEdit):
                widget.setReadOnly(True)
        # Enable fields which the Windows load handler enables after reading configuration.
        for name in STUDENT_FIELDS:
            widget = self.widget(name)
            if widget:
                parent = widget.parentWidget()
                while parent and parent is not self.form.surface:
                    parent.setEnabled(True)
                    parent = parent.parentWidget()
                widget.setEnabled(True)
        self.put('dropStatus', 1)
        for i in range(1, 10):
            self.put('txtFee' + str(i), 0)
            self.put('txttransport' + str(i), 0)
        if self.identifier:
            self.load(self.identifier)
        self.totals()

    def load_classes(self, *_):
        self.combo('dropCls', self.school.choices('classes', grade=self.get('dropPaye')), blank=False)
        self.class_fee()

    def class_fee(self, *_):
        identifier = self.get('dropCls')
        fee = self.db.scalar('SELECT fee FROM tClass WHERE id=%s', (identifier,), default=0) if identifier else 0
        self.put('txtFeeClass', fee)

    def totals(self, *_):
        for prefix, destination in [('txtFee', 'txtSumFee'), ('txttransport', 'txtSumtransport')]:
            total = 0
            for i in range(1, 10):
                try:
                    total += number(self.get(prefix + str(i))) or 0
                except ValidationError:
                    pass  # Intermediate keystrokes are validated before saving.
            self.put(destination, total)

    def load(self, identifier):
        row = self.school.student(identifier)
        if row is None:
            raise ValidationError('پروندهٔ شاگرد در سال انتخاب‌شده پیدا نشد.')
        lookup = {key.lower(): value for key, value in row.items()}
        self.put('dropPaye', row.get('xPaye'))
        self.load_classes()
        for widget, field in STUDENT_FIELDS.items():
            self.put(widget, lookup.get(field.lower()))
        images = self.db.query('SELECT Student_img FROM tStudentImg WHERE xStudent=%s', (identifier,))
        self.image = images[0]['Student_img'] if images else None
        self.show_image()
        self.identifier = identifier
        self.totals()

    def show_image(self):
        picture = self.widget('pictureBox1')
        if picture:
            pixmap = QPixmap()
            if self.image:
                pixmap.loadFromData(self.image)
            picture.setPixmap(pixmap)
            picture.setScaledContents(True)

    def save(self):
        values = {field: self.get(widget) for widget, field in STUDENT_FIELDS.items()}
        if self.image_changed:
            values['Student_img'] = self.image
        self.identifier = self.school.save_student(values, self.identifier)
        self.image_changed = False
        self.notify()
        self.changed()
        return self.identifier

    def handle(self, control):
        name = control.get('name', '').lower()
        if name == 'btnacp':
            self.save()
        elif name == 'btnpic':
            filename, _ = QFileDialog.getOpenFileName(self.form, 'انتخاب عکس شاگرد', '', 'تصویر (*.png *.jpg *.jpeg)')
            if filename:
                data = Path(filename).read_bytes()
                probe = QPixmap()
                if not probe.loadFromData(data):
                    raise ValidationError('فایل انتخاب‌شده تصویر معتبر نیست.')
                self.image, self.image_changed = data, True
                self.show_image()
        elif name == 'btndeletepic':
            self.image, self.image_changed = None, True
            self.show_image()
        elif name in ('btnnext', 'btnprevious'):
            rows = self.school.students()
            ids = [row['id'] for row in rows]
            if self.identifier in ids:
                index = ids.index(self.identifier) + (1 if name == 'btnnext' else -1)
                if 0 <= index < len(ids):
                    self.load(ids[index])
        else:
            return False
        return True
