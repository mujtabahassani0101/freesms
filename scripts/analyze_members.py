"""Analyze all managed types in bounded REA selections, retaining full evidence."""
import json,subprocess,sys
from pathlib import Path
from concurrent.futures import ThreadPoolExecutor
ROOT=Path(__file__).resolve().parent.parent
NODE='/home/you/.local/share/mise/installs/node/24.22.1/bin/node'
CLI=str(ROOT/'rea/scripts/rea.mjs')
ARTIFACT=ROOT/'original/update/school_af.exe'
out=ROOT/'analysis/rea-types';out.mkdir(exist_ok=True)
parent=json.loads((ROOT/'analysis/rea-members.json').read_text())['records'][0]['normalized_result']
types=[r['full_name'] for r in parent['types'] if r['method_list']['count'] or r['field_list']['count']]
# Single-type decoding avoids the metadata representation limit hit by all-types decoding.
def inspect(item):
 index,name=item;dest=out/f'{index:03d}.json';summary=out/f'{index:03d}-summary.json'
 if not dest.exists():
  p=subprocess.run([NODE,CLI,'inspect-managed-members',str(ARTIFACT),'--type',name,'--detail','summary','--evidence-bundle',str(dest),'--format','json'],capture_output=True,text=True,timeout=120)
  summary.write_text(p.stdout)
  if p.returncode:return {'type':name,'error':p.stderr[-1000:]}
 try:
  row=json.loads(dest.read_text())['records'][0]['normalized_result']
  return {'type':name,'evidence':str(dest.relative_to(ROOT)),'coverage':row['coverage'],'fields':len(row['fields']),'methods':len(row['methods'])}
 except Exception as exc:return {'type':name,'error':str(exc)}
with ThreadPoolExecutor(max_workers=2) as pool:
 results=list(pool.map(inspect,enumerate(types)))
(out/'index.json').write_text(json.dumps(results,ensure_ascii=False,indent=2))
print(json.dumps({'types':len(results),'complete':sum(x.get('coverage',{}).get('state')=='complete' for x in results),'errors':[x for x in results if 'error' in x]}))
