from .base import Controller
from .reference import REFERENCE_FORMS, ReferenceController, SchoolController
from .students import StudentController, StudentListController
from .settings import MainController, YearController, TeacherAssignmentController, ColorController


def create_controller(form, runtime, context=None):
    name = form.definition.get('name')
    if name == 'frmMain':
        cls = MainController
    elif name == 'frmSetDefYear':
        cls = YearController
    elif name == 'frmTchClass':
        cls = TeacherAssignmentController
    elif name == 'frmbackColor':
        cls = ColorController
    elif name == 'frmSchool':
        cls = SchoolController
    elif name in REFERENCE_FORMS:
        cls = ReferenceController
    elif name == 'frmlistStd':
        cls = StudentListController
    elif name == 'frmSabtenam':
        cls = StudentController
    else:
        cls = Controller
    return cls(form, runtime, context)
