"""Native Qt reconstruction of recovered WinForms controls.

Layout metadata is an observation of the shipped binary, not a claim that
business behavior has been ported. Preview is explicitly read-only.
"""
from pathlib import Path
import json
import sys
from PySide6.QtCore import Qt,QSize
from PySide6.QtGui import QFont,QColor,QPalette,QPixmap,QIcon,QAction,QPainter
from PySide6.QtWidgets import (QApplication,QWidget,QLabel,QLineEdit,QPushButton,
 QCheckBox,QRadioButton,QComboBox,QTableWidget,QTableWidgetItem,QFrame,
 QGroupBox,QMenuBar,QDialog,QScrollArea,QVBoxLayout,QMessageBox,QListWidget,
 QSpinBox,QTextEdit,QTabWidget,QMenu)

ASSETS=(Path(sys._MEIPASS)/'native/assets') if getattr(sys,'frozen',False) else Path(__file__).parent/'assets'
FORMS=json.loads((ASSETS/'forms.json').read_text(encoding='utf-8'))
BY_CLASS={f['class']:f for f in FORMS}
BY_NAME={f.get('name'):f for f in FORMS}

class Surface(QWidget):
 def __init__(self,parent=None,image=None):
  super().__init__(parent)
  self.background=QPixmap(str(ASSETS/image)) if image else QPixmap()
 def paintEvent(self,event):
  super().paintEvent(event)
  if not self.background.isNull():
   painter=QPainter(self);painter.drawPixmap(self.rect(),self.background)

class LegacyForm(QDialog):
 def __init__(self,definition,parent=None,preview=True,runtime=None,context=None):
  super().__init__(parent)
  self.runtime=runtime;self.context=context or {}
  self.definition=definition;self.preview=preview;self.widgets={};self.windows=[]
  self.setWindowTitle((definition.get('text') or definition.get('name') or '')+(' — پیش‌نمایش رابط' if preview else ''))
  self.setWindowIcon(QIcon(str(ASSETS/'app.ico')))
  self.setLayoutDirection(Qt.RightToLeft)
  width,height=definition.get('clientsize',[800,600])
  self.resize(width+2,height+2)
  self.surface=Surface(self,definition.get('image'));self.surface.setFixedSize(width,height)
  self.scroll=QScrollArea(self);self.scroll.setWidget(self.surface);self.scroll.setWidgetResizable(False)
  self.scroll.setFrameShape(QFrame.NoFrame)
  self.widgets['this']=self.surface
  self.controls={c['variable']:c for c in definition['controls']}
  pending=list(definition['controls'])
  for _ in range(len(pending)+1):
   if not pending:break
   next_pending=[]
   for c in pending:
    if c.get('parent','this') not in self.widgets:next_pending.append(c);continue
    self.make_control(c)
   if len(next_pending)==len(pending):break
   pending=next_pending
  for c in pending:
   c=dict(c,parent='this');self.make_control(c)
  self.setup_menus()
  self.resizeEvent(None)
  if runtime is not None and not preview:runtime.bind(self,self.context)

 def make_control(self,c):
  typ=c['type'];parent=self.widgets.get(c.get('parent','this'),self.surface)
  if typ in ('ToolStripMenuItem','ToolStripSeparator','UIComboBoxItem') or typ.endswith('Dialog'):return
  text=c.get('text','')
  if typ=='MenuStrip':w=QMenuBar(parent)
  elif typ=='Label':w=QLabel(text,parent);w.setAlignment(Qt.AlignRight|Qt.AlignVCenter)
  elif typ in ('EditBox','TextBox','MaskedEditBox','NumericEditBox'):w=QLineEdit(text,parent)
  elif typ in ('UIButton','Button'):w=QPushButton(text,parent)
  elif typ in ('CheckBox','UICheckBox'):w=QCheckBox(text,parent)
  elif typ in ('RadioButton','UIRadioButton'):w=QRadioButton(text,parent)
  elif typ in ('UIComboBox','ComboBox','ComboBoxBase','MultiColumnCombo'):w=QComboBox(parent)
  elif typ=='NumericUpDown':w=QSpinBox(parent);w.setRange(0,10000)
  elif typ=='DatePicker':w=QLineEdit(text,parent)
  elif typ=='GridEX':
   w=QTableWidget(parent)
   layouts=self.definition.get('layouts',[])
   cols=next((x['columns'] for x in layouts if x['resource']==c.get('gridlayout')),layouts[0]['columns'] if layouts else [])
   cols=[x for x in cols if x.get('Visible')!='False']
   w.native_columns=[x.get('DataMember') or x.get('Key') or '' for x in cols]
   w.setColumnCount(len(cols));w.setHorizontalHeaderLabels([x.get('Caption') or x.get('Key') or '' for x in cols])
   for i,col in enumerate(cols):w.setColumnWidth(i,int(col.get('Width') or 100))
   w.setAlternatingRowColors(True);w.setEditTriggers(QTableWidget.NoEditTriggers)
   w.setSelectionBehavior(QTableWidget.SelectRows)
  elif typ in ('UIGroupBox','GroupBox'):w=QGroupBox(text,parent)
  elif typ=='PictureBox':w=QLabel(parent)
  elif typ=='ListBox':w=QListWidget(parent)
  elif typ=='TabControl':w=QTabWidget(parent)
  elif typ in ('Panel','TabPage','Splitter'):w=QFrame(parent)
  else:
   # Nonvisual components and report engines have no rendered control.
   return
  self.widgets[c['variable']]=w
  w.setPalette(QApplication.palette())
  if isinstance(w,QComboBox):w.addItems(c.get('options',[]))
  w.setObjectName(c.get('name',c['variable']))
  x,y=c.get('location',[0,0]);width,height=c.get('size',[100,24]);w.setGeometry(x,y,width,height)
  f=c.get('font')
  if f:w.setFont(QFont(f['family'],round(f['pt']),QFont.Bold if f['bold'] else QFont.Normal))
  for prop,role in [('backcolor',QPalette.Window),('forecolor',QPalette.WindowText)]:
   if prop in c:
    value=c[prop];color=QColor(*value) if isinstance(value,list) else QColor({'Control':'#f0f0f0','Window':'white','ControlText':'black','WindowText':'black','GradientInactiveCaption':'#d7e4f2','GradientActiveCaption':'#b9d1ea','ActiveCaption':'#99b4d1','InactiveCaption':'#bfcddb','HotTrack':'#0066cc','ButtonFace':'#f0f0f0','ButtonHighlight':'white','Info':'#ffffe1'}.get(value,value))
    if color.isValid():
     pal=w.palette();pal.setColor(role,color)
     if prop=='backcolor':pal.setColor(QPalette.Base,color);pal.setColor(QPalette.Button,color);w.setAutoFillBackground(True)
     else:pal.setColor(QPalette.Text,color);pal.setColor(QPalette.ButtonText,color)
     w.setPalette(pal)
  if isinstance(w,(QCheckBox,QRadioButton)):w.setChecked(c.get('checked',False))
  if isinstance(w,(QLineEdit,QComboBox)):
   pal=w.palette();pal.setColor(QPalette.Base,QColor('white'));pal.setColor(QPalette.Text,QColor('black'));w.setPalette(pal)
  if isinstance(w,QLineEdit):
   if c.get('password'):w.setEchoMode(QLineEdit.Password)
   if c.get('maxlength'):w.setMaxLength(c['maxlength'])
   w.setReadOnly(self.preview)
  if isinstance(w,QLabel) and c.get('image'):
   w.setPixmap(QPixmap(str(ASSETS/c['image'])));w.setScaledContents(typ=='PictureBox')
  elif isinstance(w,QPushButton) and c.get('image'):
   w.setIcon(QIcon(str(ASSETS/c['image'])));w.setIconSize(QSize(min(28,height-6),min(28,height-6)))
  if isinstance(w,QPushButton):w.clicked.connect(lambda checked=False,ctrl=c:self.dispatch(ctrl))
  # The main menu is hidden until login by the Windows application's load handler.
  if c.get('visible') is False and typ!='MenuStrip':w.hide()
  if not self.preview:w.setEnabled(c.get('enabled',True))

 def setup_menus(self):
  bar=next((w for w in self.widgets.values() if isinstance(w,QMenuBar)),None)
  if bar is None:return
  meta=next(c for c in self.definition['controls'] if c['type']=='MenuStrip')
  def add(container,var):
   c=self.controls.get(var,{})
   if c.get('visible') is False:return
   if c.get('type')=='ToolStripSeparator':container.addSeparator();return
   if c.get('children'):
    menu=container.addMenu(c.get('text',''))
    for child in c['children']:add(menu,child)
   else:
    action=container.addAction(c.get('text',''))
    if c.get('image'):action.setIcon(QIcon(str(ASSETS/c['image'])))
    action.triggered.connect(lambda checked=False,ctrl=c:self.dispatch(ctrl))
  for child in meta.get('children',[]):add(bar,child)
  bar.show()

 def dispatch(self,c):
  if self.runtime is not None and hasattr(self,'controller'):
   try:
    if self.controller.handle(c):return
   except Exception as error:
    self.runtime.error(self,error);return
  name=c.get('name','').lower();text=c.get('text','')
  if any(t in name for t in ('close','exit')) or text.strip() in ('خروج','بستن'):
   self.close();return
  targets=self.definition.get('actions',{}).get(c.get('click'),[])
  target=next((BY_CLASS[t] for t in targets if t in BY_CLASS),None)
  if target:
   window=self.runtime.open(target['name'],parent=self,context={'menu_name':c.get('name')}) if self.runtime else LegacyForm(target,self,self.preview)
   self.windows.append(window);window.show();return
  if not self.preview:
   QMessageBox.information(self,'بخش در حال تکمیل','عملیات این بخش هنوز تکمیل نشده است. اطلاعاتی ثبت یا تغییر نکرد.')
  if self.preview:
   QMessageBox.information(self,'پیش‌نمایش رابط','این پنجره از چیدمان نسخهٔ اصلی بازسازی شده است. عملیات این بخش هنوز به نسخهٔ بومی منتقل و آزمایش نشده است.')

 def resizeEvent(self,event):
  if hasattr(self,'scroll'):self.scroll.setGeometry(self.rect())
  if event:super().resizeEvent(event)
