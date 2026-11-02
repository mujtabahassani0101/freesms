from __future__ import annotations

from PySide6.QtCore import Qt
from PySide6.QtWidgets import QCheckBox, QComboBox, QLineEdit, QMessageBox, QTableWidget, QTableWidgetItem, QSpinBox

from backend.services import ValidationError


class Controller:
    def __init__(self, form, runtime, context=None):
        self.form, self.runtime, self.context = form, runtime, context or {}
        self.school, self.db = runtime.school, runtime.database
        self.by_name = {widget.objectName().lower(): widget for widget in form.widgets.values()}
        self.row_sets = {}

    def widget(self, name):
        return self.by_name.get(name.lower())

    def get(self, name):
        widget = self.widget(name)
        if isinstance(widget, QSpinBox):
            return widget.value()
        if isinstance(widget, QLineEdit):
            return widget.text().strip()
        if isinstance(widget, QComboBox):
            return widget.currentData()
        if isinstance(widget, QCheckBox):
            return widget.isChecked()
        return None

    def put(self, name, value):
        widget = self.widget(name)
        if isinstance(widget, QSpinBox):
            widget.setValue(int(value or 0))
        elif isinstance(widget, QLineEdit):
            widget.setText('' if value is None else str(value))
        elif isinstance(widget, QComboBox):
            index = widget.findData(value)
            if index < 0 and value is not None:
                index = next((i for i in range(widget.count()) if str(widget.itemData(i)) == str(value)), -1)
            widget.setCurrentIndex(index)
        elif isinstance(widget, QCheckBox):
            widget.setChecked(bool(value))

    def combo(self, name, rows, *, blank=True, selected=None):
        widget = self.widget(name)
        if not isinstance(widget, QComboBox):
            return
        previous = widget.currentData() if selected is None else selected
        widget.blockSignals(True)
        widget.clear()
        if blank:
            widget.addItem('—', None)
        for row in rows:
            widget.addItem(str(row.get('name') or ''), row['id'])
        if previous is not None:
            index = widget.findData(previous)
            widget.setCurrentIndex(index if index >= 0 else 0)
        widget.blockSignals(False)

    def fill(self, name, rows):
        table = self.widget(name)
        if not isinstance(table, QTableWidget):
            return
        self.row_sets[name.lower()] = rows
        table.setSortingEnabled(False)
        table.blockSignals(True)
        table.setRowCount(len(rows))
        keys = getattr(table, 'native_columns', [])
        if not keys and rows:
            keys = list(rows[0])
            table.setColumnCount(len(keys))
            table.setHorizontalHeaderLabels(keys)
        for row_index, record in enumerate(rows):
            lookup = {key.lower(): value for key, value in record.items()}
            for column_index, key in enumerate(keys):
                value = lookup.get((key or '').lower())
                text = '' if value is None else str(value)
                item = QTableWidgetItem(text)
                item.setData(Qt.UserRole, record.get('id'))
                item.setFlags(item.flags() & ~Qt.ItemIsEditable)
                table.setItem(row_index, column_index, item)
        table.blockSignals(False)
        if rows:
            table.selectRow(0)

    def selected(self, name):
        table = self.widget(name)
        rows = self.row_sets.get(name.lower(), [])
        index = table.currentRow() if isinstance(table, QTableWidget) else -1
        return rows[index] if 0 <= index < len(rows) else None

    def changed(self):
        self.runtime.refresh_other_forms(self.form)

    def confirm(self, text):
        return QMessageBox.question(self.form, 'تأیید حذف', text, QMessageBox.Yes | QMessageBox.No, QMessageBox.No) == QMessageBox.Yes

    def notify(self, text='اطلاعات ثبت شد.'):
        self.form.setWindowTitle((self.form.definition.get('text') or '') + ' — ' + text)

    def handle(self, control):
        return False

    def refresh(self):
        pass
