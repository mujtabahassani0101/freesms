from __future__ import annotations

from PySide6.QtWidgets import QComboBox, QLineEdit, QTableWidget

from backend.entities import EntityService
from backend.services import ValidationError
from .base import Controller


REFERENCE_FORMS = {
    'frmPaye': ('grades', 'gridEX1', {'txtNam': 'Name'}),
    'frmCls': ('classes', 'gridEX1', {'txtNam': 'name', 'dropPaye': 'xpaye', 'txtAnswerable': 'answerable', 'txtFee': 'fee', 'dropShift': 'shift', 'txtSortRpt': 'sortRpt'}),
    'frmTeacher': ('teachers', 'gteacher', {'txtNamF': 'fNamF', 'txtNamL': 'fNamL', 'txtEmail': 'fEmail', 'txtPass': 'fPassword'}),
    'frmDriver': ('drivers', 'gteacher', {'txtNamF': 'name', 'txtMobile1': 'mobil', 'txtMobile2': 'mobil2', 'txtComment': 'comment'}),
    'frmbook': ('books', 'gBook', {'dropPaye': 'xPaye', 'txtBook': 'Name', 'txtVahed': 'vahed', 'txttimeWeek': 'timeWeek', 'txtSort': 'sort', 'txtCodeDars': 'codedars', 'checkVezarat': 'Vezarat'}),
    'frmTakhfif': ('discounts', 'gridEX1', {'txtNam': 'name', 'txtComment': 'comment'}),
    'frmYearMaghtaCountDay': ('year_days', 'gridEX1', {'dropMaghta': 'xMaghta', 'txtTerm1': 'Term1', 'txtTerm2': 'Term2'}),
    'frmExam': ('exams', 'gridEX1', {'txtNam': 'Name', 'txtNumExam': 'NumExam', 'txtDatafrom': 'DateFrom', 'txtDatato': 'DateTo'}),
    'frmHozeh': ('halls', 'gridEX1', {'txtName': 'Name', 'txtCapacity': 'Capacity'}),
}


class SchoolController(Controller):
    fields = {'txtOst': 'Ost', 'txtCity': 'cty', 'txtSch': 'sch', 'txtFoter1': 'Foter1'}

    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.refresh()

    def refresh(self):
        row = self.school.school()
        for widget, column in self.fields.items():
            self.put(widget, row.get(column))

    def handle(self, control):
        if control.get('name') == 'btnAcp':
            self.school.save_school({column: self.get(widget) for widget, column in self.fields.items()})
            self.notify()
            self.changed()
            return True
        return False


class ReferenceController(Controller):
    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.entity, self.grid, self.fields = REFERENCE_FORMS[self.form.definition['name']]
        self.entities = EntityService(self.school)
        self.identifier = 0
        self.rows = []
        self.combo('dropPaye', self.school.choices('grades'), blank=False)
        self.combo('dropPayeSeacrch', self.school.choices('grades'))
        self.combo('dropMaghta', self.school.choices('levels'), blank=False)
        self.combo('dropShift', [{'id': 1, 'name': 'صبح'}, {'id': 2, 'name': 'عصر'}], blank=False)
        for name in ('txtNamFSearch', 'txtNamlSearch', 'txtNameSearch'):
            widget = self.widget(name)
            if isinstance(widget, QLineEdit):
                widget.textChanged.connect(self.filter_rows)
        widget = self.widget('dropPayeSeacrch')
        if isinstance(widget, QComboBox):
            widget.currentIndexChanged.connect(self.filter_rows)
        table = self.widget(self.grid)
        if isinstance(table, QTableWidget):
            table.cellDoubleClicked.connect(lambda *_: self.edit())
        self.refresh()
        self.editing(False)

    def editing(self, enabled):
        for name in self.fields:
            widget = self.widget(name)
            if widget:
                parent = widget.parentWidget()
                while parent and parent is not self.form.surface:
                    parent.setEnabled(True)
                    parent = parent.parentWidget()
                widget.setEnabled(enabled)
        for name in ('btnAcp', 'btnAccept', 'btnCancel', 'btnCansel'):
            widget = self.widget(name)
            if widget:
                widget.setEnabled(enabled)
        if self.entity == 'classes' and self.identifier:
            self.widget('dropPaye').setEnabled(False)

    def refresh(self):
        self.rows = self.school.classes() if self.entity == 'classes' else self.entities.list(self.entity)
        if self.entity == 'books':
            grades = {row['id']: row['name'] for row in self.school.choices('grades')}
            for row in self.rows:
                row['paye'] = grades.get(row['xPaye'], '')
        if self.entity == 'year_days':
            levels = {row['id']: row['name'] for row in self.school.choices('levels')}
            for row in self.rows:
                row['maghta'] = levels.get(row['xMaghta'], '')
                row['sumyear'] = (row['Term1'] or 0) + (row['Term2'] or 0)
        self.filter_rows()

    def filter_rows(self, *_):
        rows = self.rows
        filters = {'txtNamFSearch': 'fNamF', 'txtNamlSearch': 'fNamL' if self.entity == 'teachers' else 'name', 'txtNameSearch': 'Name'}
        for widget, field in filters.items():
            text = self.get(widget)
            if text:
                rows = [row for row in rows if str(text) in str(row.get(field) or '')]
        grade = self.get('dropPayeSeacrch')
        if grade:
            rows = [row for row in rows if row.get('xPaye') == grade]
        self.fill(self.grid, rows)

    def new(self):
        self.identifier = 0
        for widget in self.fields:
            self.put(widget, None)
        self.put('dropPaye', self.school.choices('grades')[0]['id'])
        self.put('dropShift', 1)
        self.put('txtFee', 0)
        self.put('txtSortRpt', max((row.get('sortRpt') or 0 for row in self.rows), default=0) + 1)
        self.put('txtSort', max((row.get('sort') or 0 for row in self.rows), default=0) + 1)
        self.put('txtCodeDars', max((row.get('codedars') or 0 for row in self.rows), default=0) + 1)
        self.put('txtVahed', 1)
        self.put('txttimeWeek', 1)
        self.put('txtNumExam', max((row.get('NumExam') or 0 for row in self.rows), default=0) + 1)
        self.put('dropMaghta', self.school.choices('levels')[0]['id'])
        self.editing(True)
        first = next(iter(self.fields))
        self.widget(first).setFocus()

    def edit(self):
        row = self.selected(self.grid)
        if not row:
            raise ValidationError('یک مورد را از لیست انتخاب کنید.')
        self.identifier = row['id']
        lookup = {key.lower(): value for key, value in row.items()}
        for widget, field in self.fields.items():
            self.put(widget, lookup.get(field.lower()))
        self.editing(True)

    def save(self):
        values = {field: self.get(widget) for widget, field in self.fields.items()}
        if self.entity == 'classes':
            self.school.save_class(values, self.identifier)
        else:
            if self.entity == 'books':
                values.update(Type=1, SortOneEntry=values.get('sort'))
            if self.entity == 'teachers' and not self.get('checkID'):
                explicit_id = self.get('txtid')
                if explicit_id:
                    values['id'] = explicit_id
            self.entities.save(self.entity, values, self.identifier)
        self.refresh()
        self.editing(False)
        self.notify()
        self.changed()

    def handle(self, control):
        name = control.get('name', '').lower()
        if name == 'btnnew':
            self.new()
        elif name == 'btnedit':
            self.edit()
        elif name in ('btnacp', 'btnaccept'):
            self.save()
        elif name in ('btncancel', 'btncansel'):
            self.identifier = 0
            self.editing(False)
        elif name == 'btndelete':
            row = self.selected(self.grid)
            if not row:
                raise ValidationError('یک مورد را انتخاب کنید.')
            if self.confirm('مورد انتخاب‌شده حذف شود؟'):
                if self.entity == 'classes':
                    self.school.delete_class(row['id'])
                else:
                    self.entities.delete(self.entity, row['id'])
                self.refresh()
                self.changed()
        else:
            return False
        return True
