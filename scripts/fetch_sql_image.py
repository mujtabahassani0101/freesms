"""Fetch verified MCR image layers with bounded parallel HTTP ranges."""
import json,urllib.request,hashlib,os,subprocess,tarfile,shutil
from pathlib import Path
from concurrent.futures import ThreadPoolExecutor
ROOT=Path(__file__).resolve().parent.parent
OUT=ROOT/'.runtime/sql-image';BLOBS=OUT/'blobs/sha256';BLOBS.mkdir(parents=True,exist_ok=True)
BASE='https://mcr.microsoft.com/v2/mssql/server/'
def get(url,headers=None):
 with urllib.request.urlopen(urllib.request.Request(url,headers=headers or {}),timeout=60) as r:return r.read()
manifest_raw=get(BASE+'manifests/2019-latest',{'Accept':'application/vnd.docker.distribution.manifest.v2+json'})
manifest=json.loads(manifest_raw);manifest_sha=hashlib.sha256(manifest_raw).hexdigest()
(BLOBS/manifest_sha).write_bytes(manifest_raw)
store=Path('/home/you/.local/share/docker/containerd/daemon/io.containerd.content.v1.content')
for row in [manifest['config']]+manifest['layers']:
 digest=row['digest'].split(':')[1];size=row['size'];dest=BLOBS/digest
 existing=store/'blobs/sha256'/digest
 if existing.exists():shutil.copyfile(existing,dest)
 elif not dest.exists():
  # Reuse the prefix of this task's interrupted Docker download, then verify the final digest.
  prefix=None
  for p in (store/'ingest').glob('*/data'):
   total=p.parent/'total'
   if total.exists() and total.read_text().strip()==str(size):prefix=p;break
  if prefix:shutil.copyfile(prefix,dest)
  else:dest.touch()
 if dest.stat().st_size<size:
  start=dest.stat().st_size
  with dest.open('r+b') as f:f.truncate(size)
  chunk=8*1024*1024
  pieces=[(a,min(a+chunk,size)-1) for a in range(start,size,chunk)]
  fd=os.open(dest,os.O_WRONLY)
  def part(pair):
   a,b=pair;req=urllib.request.Request(BASE+'blobs/'+row['digest'],headers={'Range':f'bytes={a}-{b}'})
   with urllib.request.urlopen(req,timeout=120) as r:
    if r.status!=206:raise RuntimeError('Registry did not honor the range request')
    if r.headers.get('Content-Range')!=f'bytes {a}-{b}/{size}':raise RuntimeError('Unexpected range response')
    offset=a
    while data:=r.read(1024*1024):os.pwrite(fd,data,offset);offset+=len(data)
    if offset!=b+1:raise RuntimeError('Incomplete range')
   return pair
  try:
   with ThreadPoolExecutor(max_workers=8) as pool:
    for i,piece in enumerate(pool.map(part,pieces)):print('range',digest[:12],i+1,'/',len(pieces),flush=True)
  finally:os.close(fd)
 h=hashlib.file_digest(dest.open('rb'),'sha256').hexdigest()
 if h!=digest:raise RuntimeError('Image layer digest mismatch: '+digest)
 print('verified',digest[:12],size,flush=True)
index={'schemaVersion':2,'manifests':[{'mediaType':manifest.get('mediaType','application/vnd.docker.distribution.manifest.v2+json'),'digest':'sha256:'+manifest_sha,'size':len(manifest_raw),'annotations':{'org.opencontainers.image.ref.name':'mcr.microsoft.com/mssql/server:2019-latest'}}]}
(OUT/'index.json').write_text(json.dumps(index));(OUT/'oci-layout').write_text('{"imageLayoutVersion":"1.0.0"}')
archive=ROOT/'.runtime/sql-image.tar'
with tarfile.open(archive,'w') as tf:
 for p in OUT.rglob('*'):
  if p.is_file():tf.add(p,arcname=str(p.relative_to(OUT)))
subprocess.run(['docker','load','-i',str(archive)],check=True)
