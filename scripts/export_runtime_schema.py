import json,sys
from pathlib import Path
ROOT=Path(__file__).resolve().parent.parent
sys.path.insert(0,str(ROOT/'native'))
from backend.database import Database
b=Database().ensure_database()
out=ROOT/'native/assets/runtime-schema.json'
data={
 'columns':b.query("SELECT t.name AS table_name,c.name,ty.name AS type,c.max_length,c.is_nullable,c.is_identity,c.column_id,dc.definition AS default_definition FROM sys.columns c JOIN sys.tables t ON t.object_id=c.object_id JOIN sys.types ty ON c.user_type_id=ty.user_type_id LEFT JOIN sys.default_constraints dc ON dc.object_id=c.default_object_id ORDER BY t.name,c.column_id"),
 'parameters':b.query("SELECT o.name AS procedure_name,p.name,ty.name AS type,p.max_length,p.parameter_id,p.is_output FROM sys.parameters p JOIN sys.objects o ON o.object_id=p.object_id JOIN sys.types ty ON ty.user_type_id=p.user_type_id WHERE o.is_ms_shipped=0 ORDER BY o.name,p.parameter_id"),
 'keys':b.query("SELECT t.name AS table_name,c.name,i.is_primary_key,i.is_unique FROM sys.tables t JOIN sys.indexes i ON i.object_id=t.object_id JOIN sys.index_columns ic ON ic.object_id=t.object_id AND ic.index_id=i.index_id JOIN sys.columns c ON c.object_id=t.object_id AND c.column_id=ic.column_id WHERE i.is_unique=1 ORDER BY t.name,i.index_id,ic.key_ordinal")
}
out.write_text(json.dumps(data,ensure_ascii=False,indent=2))
for table in ['tPaye','tMaghta','tDefYear','tExam','tTakhfif','tYearMaghtaCountDay']:
 print(table,b.query('SELECT TOP 14 * FROM ['+table+']'))
print('Updated fields')
for t in sorted({x['table_name'] for x in data['columns']}):
 print(t,','.join(x['name'] for x in data['columns'] if x['table_name']==t))
