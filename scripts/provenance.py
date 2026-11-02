import hashlib,json,subprocess
from pathlib import Path
root=Path(__file__).resolve().parent.parent
out={'inputs':[],'rea':{'repository':'https://github.com/morluto/rea','commit':subprocess.check_output(['git','-C',str(root/'rea'),'rev-parse','HEAD'],text=True).strip()},'native_status':'read-only UI preview; business logic and reports are not ported'}
for name in ['Setup.rar','update14021119_3 (1).exe','original/update/school_af.exe','original/installed/db/school_af_kbr_Data.MDF','original/installed/db/school_af_kbr_Log.LDF']:
 p=root/name
 with p.open('rb') as f:d=hashlib.file_digest(f,'sha256').hexdigest()
 out['inputs'].append({'path':name,'sha256':d,'bytes':p.stat().st_size})
(root/'analysis/provenance.json').write_text(json.dumps(out,ensure_ascii=False,indent=2))
