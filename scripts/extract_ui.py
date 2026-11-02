"""Recover WinForms layout facts from ILSpy output; no target execution."""
import json,re,base64,xml.etree.ElementTree as ET
from pathlib import Path
ROOT=Path(__file__).resolve().parent.parent
SRC=ROOT/'analysis/decompiled'
OUT=ROOT/'native/assets'
OUT.mkdir(exist_ok=True,parents=True)

def literal(s):
 try:return json.loads('"'+s+'"')
 except ValueError:return s.replace('\\r','\r').replace('\\n','\n').replace('\\t','\t').replace('\\"','"').replace('\\\\','\\')

def key(s):
 return s.replace('this.','').replace('@','').strip()

def receiver(s):
 # Property assignment receivers are either cast controls or direct variables.
 s=re.sub(r'\([^()]*\)','',s)
 return key(s.replace('(','').replace(')',''))

forms=[]
for path in sorted(SRC.glob('*.cs')):
 source=path.read_text()
 if not re.search(r'public class \w+ : Form',source):continue
 methods=re.split(r'(?=\n\t(?:private|public|protected) [^\n]+\n\t\{)',source)
 init=next((s for s in methods if 'ClientSize = new Size' in s),None)
 if not init:continue
 types={key(v):t for t,v in re.findall(r'\b(?:private|public)\s+(\w+)\s+([@\w]+)\s*;',source)}
 for v,t in re.findall(r'([@\w.]+)\s*= new (\w+)\(',init):types[key(v)]=t
 ctrls={}
 for line in init.splitlines():
  m=re.match(r'\s*(.+?)\.(Name|Text|Location|Size|ClientSize|Font|BackColor|ForeColor|Visible|Enabled|Checked|PasswordChar|MaxLength|TabIndex|Dock|Anchor|SelectedIndex) = (.*);$',line)
  if not m:continue
  v,prop,value=m.groups();v=receiver(v)
  if not re.fullmatch(r'[\w]+',v):continue
  c=ctrls.setdefault(v,{'variable':v,'type':types.get(v,'Form' if v=='this' else 'Unknown')})
  if prop in ('Name','Text'):
   sm=re.fullmatch(r'"((?:[^"\\]|\\.)*)"',value)
   if sm:c[prop.lower()]=literal(sm.group(1))
  elif prop in ('Size','ClientSize','Location'):
   sm=re.search(r'new (?:Point|Size)\((-?\d+), (-?\d+)\)',value)
   if sm:c[prop.lower()]=list(map(int,sm.groups()))
  elif prop=='Font':
   sm=re.search(r'new Font\("([^"]+)", ([\d.]+)f(?:, \(FontStyle\)(\d+))?',value)
   if sm:c['font']={'family':sm[1],'pt':float(sm[2]),'bold':sm[3]=='1'}
  elif prop in ('Visible','Enabled','Checked'):
   if value in ('true','false'):c[prop.lower()]=value=='true'
  elif prop in ('TabIndex','MaxLength','SelectedIndex') and value.isdigit():c[prop.lower()]=int(value)
  elif prop in ('BackColor','ForeColor'):
   sm=re.search(r'(?:SystemColors|Color)\.(\w+)(?:\(([^)]+)\))?',value)
   if sm:c[prop.lower()]=[int(x.strip()) for x in sm[2].split(',')] if sm[1]=='FromArgb' and sm[2] else sm[1]
  elif prop=='PasswordChar':c['password']=True
  elif prop in ('Dock','Anchor'):
   sm=re.search(r'\)(\d+)',value)
   if sm:c[prop.lower()]=int(sm[1])
 for par,child in re.findall(r'(.+?)\.Controls\.Add\((.+)\);',init):
  par=receiver(par.strip());child=receiver(child)
  if child in ctrls:ctrls[child]['parent']=par
 events={}
 for v,handler in re.findall(r'(.+?)\.Click \+= (@?\w+);',init):events[receiver(v.strip())]=handler.lstrip('@')
 for v,c in ctrls.items():
  if v in events:c['click']=events[v]
 for v,layout in re.findall(r'([\w.@]+)\.DesignTimeLayout = ([\w]+);',init):
  if key(v) in ctrls:
   match=re.search(re.escape(layout)+r'\.LayoutString = \w+\.GetString\("([^"]+)"\)',init)
   ctrls[key(v)]['gridlayout']=match[1] if match else layout+'.LayoutString'
 for m in re.finditer(r'([^\n]+?)\.Items\.AddRange\(new UIComboBoxItem\[\d+\]\s*\{([^}]+)\}',init):
  par=receiver(m[1].strip())
  if par in ctrls:ctrls[par]['options']=[ctrls.get(key(x.strip()),{}).get('text','') for x in m[2].split(',') if x.strip()]
 # Retain menu hierarchy and its exact original order.
 for m in re.finditer(r'([^\n]+?)\.(Items|DropDownItems)\.AddRange\([^;]+;',init):
  par=receiver(m[1].strip())
  children=[key(v) for v in re.findall(r'\(ToolStripItem\)(?:\(object\))?([\w.@]+)',m[0])]
  if par in ctrls:ctrls[par]['children']=children
 # Resolve each click handler's destination forms from the decompiled method.
 actions={}
 for method in methods:
  signature=re.match(r'\n\t(?:private|public|protected) \w+ (@?\w+)\(',method)
  if not signature:continue
  targets=re.findall(r'new (asd\w*)\(',method)
  if targets:actions[signature[1].lstrip('@')]=list(dict.fromkeys(targets))
 # Extract grid column layout and bitmap data from source resources.
 layouts=[]
 res=path.with_suffix('.resx')
 if res.exists():
  for d in ET.parse(res).getroot().findall('data'):
   name=d.attrib.get('name','');val=d.findtext('value') or ''
   if name.endswith('.LayoutString'):
    try:
     root=ET.fromstring(val);cols=[]
     for col in root.findall('.//Columns/*'):
      cols.append({k:col.findtext(k) for k in ('Key','Caption','DataMember','Width','Visible','EditType')})
     layouts.append({'resource':name,'columns':cols})
    except ET.ParseError:pass
   elif d.attrib.get('mimetype','').endswith('base64'):
    try:b=base64.b64decode(val)
    except ValueError:continue
    for sig,ext in [(b'\x89PNG\r\n\x1a\n','png'),(b'\xff\xd8\xff','jpg'),(b'GIF8','gif')]:
     off=b.find(sig)
     if off>=0:
      fn=f'{path.stem}_{name.replace("$","").replace(".","_")}.{ext}'
      (OUT/fn).write_bytes(b[off:])
      for c in ctrls.values():
       if c.get('name','this')+'.Image'==name or c['variable']=='this' and name=='$this.BackgroundImage':c['image']=fn
      break
 form=ctrls.pop('this',{})
 form.update({'class':path.stem,'controls':list(ctrls.values()),'layouts':layouts,'actions':actions,'runtime_background_targets':[receiver(v) for v in re.findall(r'([^\n]+?)\.BackColor = Color\.FromArgb\(red, green, blue\);',source)],'source':str(path.relative_to(ROOT))})
 forms.append(form)
(OUT/'forms.json').write_text(json.dumps(forms,ensure_ascii=False,indent=2))
print(f'{len(forms)} forms, {sum(len(f["controls"]) for f in forms)} controls, {sum(len(f["layouts"]) for f in forms)} grids')
