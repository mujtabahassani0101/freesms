from pathlib import Path
import json,re,sys,hashlib
ROOT=Path(__file__).resolve().parent.parent
sys.path.insert(0,str(ROOT/'native'))
from backend.migrations import batches,migration_version
out=ROOT/'native/sql';out.mkdir(exist_ok=True)
catalog={}
source=[]
for path in list((ROOT/'analysis/database/modules').glob('*.sql'))+list((ROOT/'analysis/database/recovered-modules').glob('*.sql')):
 source.append((str(path.relative_to(ROOT)),path.read_text()))
for row in sorted(json.loads((ROOT/'analysis/sql-resources/index.json').read_text()),key=lambda x:migration_version(x['resource'])):
 source.append((row['file'],(ROOT/row['file']).read_text()))
for provenance,text in source:
 for batch in batches(text):
  match=re.search(r'\b(?:CREATE|ALTER)\s+(PROC(?:EDURE)?|FUNCTION|VIEW|TRIGGER)\s+([\[\]\w.]+)',batch,re.I)
  if not match:continue
  name=match[2].replace('[','').replace(']','')
  name=name.removeprefix('dbo.')
  code=batch[match.start():]
  filename=re.sub(r'[^\w.-]','_',name)+'.sql'
  (out/filename).write_text(code)
  catalog[name.lower()]={'name':name,'kind':match[1].upper(),'file':str((out/filename).relative_to(ROOT)),'source':provenance,'sha256':hashlib.sha256(code.encode()).hexdigest()}
(out/'source-index.json').write_text(json.dumps(catalog,ensure_ascii=False,indent=2))
print(len(catalog),'latest recovered SQL definitions')
