from PySide6.QtWidgets import QMessageBox
from PySide6.QtGui import QColor, QPalette

from backend.services import SchoolService
from controllers import create_controller


class ApplicationRuntime:
    def __init__(self, database, session=None):
        self.database = database
        self.school = SchoolService(database, session)
        self.forms = []
        self.color = None

    def apply_theme(self, form):
        if self.color is None:
            rows = self.database.query('SELECT TOP 1 R,G,B FROM tFormColor')
            self.color = QColor(rows[0]['R'], rows[0]['G'], rows[0]['B']) if rows else QColor(190, 210, 255)
        for variable in form.definition.get('runtime_background_targets', []):
            widget = form.widgets.get(variable)
            if widget:
                palette = widget.palette()
                palette.setColor(QPalette.Window, self.color)
                widget.setPalette(palette)
                widget.setAutoFillBackground(True)

    def bind(self, form, context=None):
        self.apply_theme(form)
        form.controller = create_controller(form, self, context)
        self.forms.append(form)

    def open(self, name, parent=None, context=None):
        from layout import BY_NAME, LegacyForm
        form = LegacyForm(BY_NAME[name], parent, preview=False, runtime=self, context=context)
        form.show()
        return form

    def refresh_other_forms(self, origin):
        for form in list(self.forms):
            try:
                if form is not origin and form.isVisible() and hasattr(form, 'controller'):
                    self.apply_theme(form)
                    form.controller.refresh()
            except RuntimeError:
                self.forms.remove(form)

    def error(self, form, error):
        QMessageBox.warning(form, 'اطلاعات ثبت نشد', str(error))
