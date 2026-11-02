"""Attach an expendable copy of the installer database to local SQL Server.

Never opens the supplied MDF for writing. Dumps metadata and procedure source
for the native port. Reads credentials from a private task-local environment file.
"""
import os,json,secrets,subprocess,time
from pathlib import Path
from decimal import Decimal
import pymssql
ROOT=Path(__file__).resolve().parent.parent
RUNTIME=ROOT/'.runtime';RUNTIME.mkdir(exist_ok=True)
ENV=RUNTIME/'sql.env'
if not ENV.exists():
 ENV.write_text('ACCEPT_EULA=Y\nMSSQL_PID=Developer\nMSSQL_SA_PASSWORD=Md!'+secrets.token_urlsafe(24)+'\nMSSQL_MEMORY_LIMIT_MB=2048\n');ENV.chmod(0o600)
values=dict(x.split('=',1) for x in ENV.read_text().splitlines() if '=' in x)
name='modiryar-analysis-sql'
exists=subprocess.run(['docker','container','inspect',name],stdout=subprocess.DEVNULL,stderr=subprocess.DEVNULL).returncode==0
if not exists:
 subprocess.run(['docker','run','-d','--name',name,'--env-file',str(ENV),'-p','127.0.0.1:15433:1433','--memory','3g','--cpus','2','mcr.microsoft.com/mssql/server:2019-latest'],check=True,stdout=subprocess.DEVNULL)
else:subprocess.run(['docker','start',name],check=True,stdout=subprocess.DEVNULL)
for attempt in range(60):
 try:
  connection=pymssql.connect(server='127.0.0.1',port=15433,user='sa',password=values['MSSQL_SA_PASSWORD'],login_timeout=2,timeout=30,autocommit=True,as_dict=True)
  break
 except pymssql.Error:
  if attempt==59:raise
  time.sleep(1)
cur=connection.cursor();cur.execute("SELECT DB_ID('school_af_kbr') AS id")
if cur.fetchone()['id'] is None:
 for original,copy in [('school_af_kbr_Data.MDF','school-analysis.mdf'),('school_af_kbr_Log.LDF','school-analysis.ldf')]:
  subprocess.run(['docker','cp',str(ROOT/'original/installed/db'/original),name+':/var/opt/mssql/data/'+copy],check=True)
 subprocess.run(['docker','exec','-u','0',name,'chown','mssql:root','/var/opt/mssql/data/school-analysis.mdf','/var/opt/mssql/data/school-analysis.ldf'],check=True)
 cur.execute("CREATE DATABASE [school_af_kbr] ON (FILENAME='/var/opt/mssql/data/school-analysis.mdf'), (FILENAME='/var/opt/mssql/data/school-analysis.ldf') FOR ATTACH")
cur.execute('USE school_af_kbr')
cur.execute('DBCC CHECKDB WITH NO_INFOMSGS, ALL_ERRORMSGS')
while cur.nextset():pass
out=ROOT/'analysis/database';out.mkdir(exist_ok=True)
queries={
 'tables':"SELECT s.name AS schema_name,t.name,t.object_id FROM sys.tables t JOIN sys.schemas s ON t.schema_id=s.schema_id ORDER BY s.name,t.name",
 'columns':"SELECT t.name AS table_name,c.name,ty.name AS type,c.max_length,c.precision,c.scale,c.is_nullable,c.is_identity,c.column_id FROM sys.columns c JOIN sys.tables t ON t.object_id=c.object_id JOIN sys.types ty ON c.user_type_id=ty.user_type_id ORDER BY t.name,c.column_id",
 'modules':"SELECT o.name,o.type_desc,sm.definition,CASE WHEN sm.definition IS NULL THEN 1 ELSE 0 END AS definition_unavailable FROM sys.objects o LEFT JOIN sys.sql_modules sm ON o.object_id=sm.object_id WHERE o.type IN ('P','V','FN','IF','TF','TR') AND o.is_ms_shipped=0 ORDER BY o.name",
 'foreign_keys':"SELECT fk.name,OBJECT_NAME(fkc.parent_object_id) AS table_name,COL_NAME(fkc.parent_object_id,fkc.parent_column_id) AS column_name,OBJECT_NAME(fkc.referenced_object_id) AS referenced_table,COL_NAME(fkc.referenced_object_id,fkc.referenced_column_id) AS referenced_column FROM sys.foreign_keys fk JOIN sys.foreign_key_columns fkc ON fk.object_id=fkc.constraint_object_id"
}
for label,query in queries.items():
 cur.execute(query);rows=cur.fetchall();(out/(label+'.json')).write_text(json.dumps(rows,ensure_ascii=False,indent=2,default=str))
 if label=='modules':
  modules=out/'modules';modules.mkdir(exist_ok=True)
  for row in rows:
   if row['definition'] is not None:
    filename=''.join(c for c in row['name'] if c.isalnum() or c in '_-')+'.sql';(modules/filename).write_text(row['definition'])
 print(label,len(rows),flush=True)
# Preserve configured UI colors and school metadata only; never create demonstration students.
for table in ['tFormColor','tParmetr']:
 cur.execute('SELECT * FROM ['+table+']');rows=cur.fetchall();(out/(table+'.json')).write_text(json.dumps(rows,ensure_ascii=False,indent=2,default=str))
connection.close()
subprocess.run(['docker','stop',name],check=True,stdout=subprocess.DEVNULL)
print('Database metadata retained; analysis container stopped.',flush=True)
