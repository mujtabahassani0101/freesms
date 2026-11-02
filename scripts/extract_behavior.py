"""Index source-observed SQL strings and parameter bindings for manual porting."""
import json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parent.parent
forms=json.loads((ROOT/'native/assets/forms.json').read_text())
literal=re.compile(r'"((?:[^"\\]|\\.)*)"')
def decode(value):
 try:return json.loads('"'+value+'"')
 except ValueError:return value
result=[]
for form in forms:
 path=ROOT/form['source'];source=path.read_text()
 statements=[];bindings=[]
 for line_number,line in enumerate(source.splitlines(),1):
  for match in literal.finditer(line):
   value=decode(match[1])
   if re.search(r'\b(?:SELECT|INSERT INTO|UPDATE|DELETE FROM|ALTER TABLE|CREATE TABLE|CREATE PROC|sp_\w+|exec\s+)\b',value,re.I):
    statements.append({'line':line_number,'literal':value})
  match=re.search(r'asdcb\.a\("(@[^\"]+)", SqlDbType\.(\w+), (.*)\)',line)
  if match:bindings.append({'line':line_number,'parameter':match[1],'sql_type':match[2],'expression':match[3].rstrip(',')})
 result.append({'class':form['class'],'form':form.get('name'),'source':form['source'],'sql_literals':statements,'parameter_bindings':bindings,'click_destinations':form['actions']})
(ROOT/'analysis/behavior-map.json').write_text(json.dumps(result,ensure_ascii=False,indent=2))
print('Forms',len(result),'SQL literals',sum(len(x['sql_literals']) for x in result),'bindings',sum(len(x['parameter_bindings']) for x in result))
