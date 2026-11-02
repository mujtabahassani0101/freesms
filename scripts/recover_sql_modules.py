"""Read-only recovery of SQL module source from this task's database copy.

Method reference (primary reverse-engineering account):
https://sqlperformance.com/2016/05/sql-performance/the-internals-of-with-encryption
The original installer database and application activation are untouched.
"""
import hashlib,json,os,re,subprocess,time
from pathlib import Path
ROOT=Path(__file__).resolve().parent.parent
NAME='modiryar-analysis-sql'
values=dict(x.split('=',1) for x in (ROOT/'.runtime/sql.env').read_text().splitlines() if '=' in x)
env=dict(os.environ,SQLCMDPASSWORD=values['MSSQL_SA_PASSWORD'])
def rc4(key,data):
 state=list(range(256));j=0
 for i in range(256):
  j=(j+state[i]+key[i%len(key)])&255;state[i],state[j]=state[j],state[i]
 i=j=0;out=bytearray()
 for value in data:
  i=(i+1)&255;j=(j+state[i])&255;state[i],state[j]=state[j],state[i]
  out.append(value^state[(state[i]+state[j])&255])
 return bytes(out)
# Validate the implementation against the standard RC4 test vector.
assert rc4(b'Key',b'Plaintext').hex()=='bbf316e8d940af0ad3'
subprocess.run(['docker','start',NAME],check=True,stdout=subprocess.DEVNULL)
query="""SET NOCOUNT ON;
DECLARE @family binary(16);
SELECT @family=CONVERT(binary(16),family_guid) FROM sys.database_recovery_status WHERE database_id=DB_ID();
SELECT o.name,o.type_desc,s.objid,s.subobjid,
 CONVERT(varchar(max),s.imageval,2) AS ciphertext,
 CONVERT(varchar(40),HASHBYTES('SHA1',@family+CONVERT(binary(4),REVERSE(CONVERT(binary(4),s.objid)))+CONVERT(binary(2),REVERSE(CONVERT(binary(2),s.subobjid)))),2) AS key_hex
FROM sys.sysobjvalues s JOIN sys.objects o ON o.object_id=s.objid
WHERE s.valclass=1 AND OBJECTPROPERTY(o.object_id,'IsEncrypted')=1 AND o.is_ms_shipped=0
FOR JSON PATH;"""
try:
 for attempt in range(30):
  proc=subprocess.run(['docker','exec','-e','SQLCMDPASSWORD',NAME,'/opt/mssql-tools18/bin/sqlcmd','-S','127.0.0.1,1434','-U','sa','-C','-d','school_af_kbr','-Q',query,'-y','0','-w','65535','-b','-l','2'],env=env,capture_output=True,text=True)
  if proc.returncode==0:break
  if attempt==29 or 'Sqlcmd: The ' in proc.stderr:raise RuntimeError(proc.stderr.strip() or proc.stdout[:500])
  time.sleep(1)
 raw=''.join(line.strip() for line in proc.stdout.splitlines() if line.strip() and not line.startswith('JSON_') and set(line.strip())!={'-'})
 rows=json.loads(raw)
 out=ROOT/'analysis/database/recovered-modules';out.mkdir(exist_ok=True)
 index=[]
 for row in rows:
  cipher=bytes.fromhex(row['ciphertext']);plain=rc4(bytes.fromhex(row['key_hex']),cipher)
  text=plain.decode('utf-16-le').rstrip('\0')
  if not re.search(r'\b(?:CREATE|ALTER)\s+(?:PROC(?:EDURE)?|VIEW|FUNCTION|TRIGGER)\b',text,re.I):
   raise RuntimeError('Recovered text failed declaration check: '+row['name'])
  filename=re.sub(r'[^\w.-]','_',row['name'])+'.sql';(out/filename).write_text(text)
  index.append({'name':row['name'],'type':row['type_desc'],'object_id':row['objid'],'subobject_id':row['subobjid'],'file':str((out/filename).relative_to(ROOT)),'ciphertext_sha256':hashlib.sha256(cipher).hexdigest(),'source_sha256':hashlib.sha256(text.encode()).hexdigest(),'characters':len(text)})
 (out/'index.json').write_text(json.dumps(index,ensure_ascii=False,indent=2))
 print('Recovered encrypted module definitions:',len(index),flush=True)
finally:
 subprocess.run(['docker','stop',NAME],stdout=subprocess.DEVNULL,check=True)
