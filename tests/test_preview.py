import os,sys,unittest
os.environ.setdefault('QT_QPA_PLATFORM','offscreen')
from pathlib import Path
sys.path.insert(0,str(Path(__file__).resolve().parents[1]/'native'))
from PySide6.QtWidgets import QApplication,QMenuBar,QPushButton
from layout import LegacyForm,FORMS,BY_NAME

class PreviewTest(unittest.TestCase):
 @classmethod
 def setUpClass(cls):cls.app=QApplication.instance() or QApplication([])
 def test_all_recovered_forms_render(self):
  for definition in FORMS:
   with self.subTest(form=definition.get('name')):
    form=LegacyForm(definition);form.show();self.app.processEvents()
    self.assertFalse(form.grab().isNull());form.close();form.deleteLater();self.app.processEvents()
 def test_main_menu_opens_recovered_school_form(self):
  form=LegacyForm(BY_NAME['frmMain'])
  control=next(c for c in form.controls.values() if c.get('name')=='toolfrmSchool')
  form.dispatch(control)
  self.assertEqual(form.windows[0].definition['name'],'frmSchool')
  for child in form.windows:child.close()
  form.close()
 def test_preview_never_allows_data_entry(self):
  form=LegacyForm(BY_NAME['frmSchool'])
  self.assertTrue(form.findChild(__import__('PySide6.QtWidgets',fromlist=['QLineEdit']).QLineEdit,'txtSch').isReadOnly())
  form.close()
if __name__=='__main__':unittest.main()
