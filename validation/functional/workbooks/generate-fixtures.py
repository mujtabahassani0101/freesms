from pathlib import Path
from zipfile import ZipFile,ZIP_DEFLATED
from xml.etree.ElementTree import Element,SubElement,tostring
import json,hashlib
base=Path(__file__).resolve().parent
main='http://schemas.openxmlformats.org/spreadsheetml/2006/main'
rel='http://schemas.openxmlformats.org/officeDocument/2006/relationships'
pkg='http://schemas.openxmlformats.org/package/2006/relationships'
ct='http://schemas.openxmlformats.org/package/2006/content-types'
def col(i):
 s=''
 while i:
  i,j=divmod(i-1,26);s=chr(65+j)+s
 return s
def workbook(name,rows,sheet='Sheet1',extra=False):
 with ZipFile(base/name,'w',ZIP_DEFLATED) as z:
  types=Element('Types',xmlns=ct)
  for ext,typ in [('xml','application/xml'),('rels','application/vnd.openxmlformats-package.relationships+xml')]:SubElement(types,'Default',Extension=ext,ContentType=typ)
  SubElement(types,'Override',PartName='/xl/workbook.xml',ContentType='application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml')
  wb=Element('workbook',xmlns=main);sheets=SubElement(wb,'sheets');rels=Element('Relationships',xmlns=pkg)
  for idx,(title,data) in enumerate(([('Unrelated', [['wrong'],['ignore']])] if extra else [])+[(sheet,rows)],1):
   SubElement(sheets,'sheet',{'name':title,'sheetId':str(idx),'{'+rel+'}id':'rId'+str(idx)})
   SubElement(rels,'Relationship',Id='rId'+str(idx),Type=rel+'/worksheet',Target='worksheets/sheet'+str(idx)+'.xml')
   SubElement(types,'Override',PartName='/xl/worksheets/sheet'+str(idx)+'.xml',ContentType='application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml')
   root=Element('worksheet',xmlns=main);sd=SubElement(root,'sheetData')
   for r,values in enumerate(data,1):
    row=SubElement(sd,'row',r=str(r))
    for c,value in enumerate(values,1):
     if value is None:continue
     cell=SubElement(row,'c',r=col(c)+str(r))
     if isinstance(value,(float,int)):SubElement(cell,'v').text=str(value)
     elif isinstance(value,tuple):cell.set('t','e');SubElement(cell,'v').text=value[1]
     else:
      cell.set('t','inlineStr');t=SubElement(SubElement(cell,'is'),'t');t.set('{http://www.w3.org/XML/1998/namespace}space','preserve');t.text=value
   z.writestr('xl/worksheets/sheet'+str(idx)+'.xml',tostring(root))
  z.writestr('xl/workbook.xml',tostring(wb));z.writestr('xl/_rels/workbook.xml.rels',tostring(rels));z.writestr('[Content_Types].xml',tostring(types))
  rootrel=Element('Relationships',xmlns=pkg);SubElement(rootrel,'Relationship',Id='rId1',Type=rel+'/officeDocument',Target='xl/workbook.xml');z.writestr('_rels/.rels',tostring(rootrel))
headers=['Sort','Code','Paye','Class','Name','Family','Father','Jens','NumberAsas','MainFees','StdFees','StdFeesKoll','Payment','Dakhele','Exam','Uniform','MobileFather','MobileMother']
student=[1,'001234',1,'صنف آزمایشی',"نام ' آزمون",'پدر','پدرکلان',0,1234,1000,50,100,0,0,0,0,'0700000000','']
second=student.copy();second[0]=2;second[1]='۱۲۳۵';second[4]='شاگرد دوم';second[8]=1235
skipped=student.copy();skipped[1]='999999';skipped[3]=None
workbook('students-valid.xlsx',[headers,student,[None]*18,second,skipped],extra=True)
workbook('marks-valid.xlsx',[[' Code ','CODEDARS','Mark'],['001234',5998001,25.5],[None,None,None],['۱۲۳۵','۵۹۹۸۰۰۱',0],['1236',5998001,None]],extra=True)
workbook('duplicate-header.xlsx',[['Code','codedars','mark','CODE'],['1234',1,25,'1234']])
workbook('missing-header.xlsx',[['Code','mark'],['1234',25]])
workbook('unnamed-data.xlsx',[['code','codedars','mark',None],['1234',1,25,'lost']])
workbook('reserved-header.xlsx',[['code','codedars','mark','status'],['1234',1,25,'fake']])
workbook('cell-error.xlsx',[['code','codedars','mark'],['1234',1,('error','#DIV/0!')]])
workbook('missing-sheet.xlsx',[['code','codedars','mark'],['1234',1,25]],sheet='WrongSheet')
workbook('marks-empty.xlsx',[['code','codedars','mark']])
(base/'corrupt.xlsx').write_bytes(b'Not an Excel workbook')
manifest={p.name:hashlib.sha256(p.read_bytes()).hexdigest() for p in sorted(base.glob('*.xlsx'))}
(base/'SHA256.json').write_text(json.dumps(manifest,indent=2)+'\n')
print('Created',len(manifest),'independent OOXML fixtures')
