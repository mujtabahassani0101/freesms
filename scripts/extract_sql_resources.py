"""Extract embedded SQL source resources, preserving resource identity and digests."""
import re,json,hashlib,xml.etree.ElementTree as ET
from pathlib import Path
ROOT=Path(__file__).resolve().parent.parent
OUT=ROOT/'analysis/sql-resources';OUT.mkdir(exist_ok=True)
index=[]
for resx in (ROOT/'analysis/decompiled').rglob('*.resx'):
 for data in ET.parse(resx).getroot().findall('data'):
  text=data.findtext('value') or '';name=data.attrib.get('name','')
  if data.attrib.get('mimetype') or not re.search(r'\b(?:CREATE|ALTER)\s+(?:PROC(?:EDURE)?|TABLE|VIEW|FUNCTION)|UPDATE\s+tVer\b',text,re.I):continue
  filename=resx.stem+'_'+re.sub(r'[^\w.-]','_',name)+'.sql'
  (OUT/filename).write_text(text)
  index.append({'source':str(resx.relative_to(ROOT)),'resource':name,'file':str((OUT/filename).relative_to(ROOT)),'characters':len(text),'sha256':hashlib.sha256(text.encode()).hexdigest(),'procedure_declarations':re.findall(r'(?:CREATE|ALTER)\s+PROC(?:EDURE)?\s+([^\s(]+)',text,re.I)})
(OUT/'index.json').write_text(json.dumps(index,ensure_ascii=False,indent=2))
print('SQL resources',len(index),'characters',sum(x['characters'] for x in index),'procedure declarations',sum(len(x['procedure_declarations']) for x in index))
