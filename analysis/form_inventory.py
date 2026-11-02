from pathlib import Path
import re,json
rows=[]
for p in sorted(Path('analysis/decompiled').glob('*.cs')):
 s=p.read_text()
 if not re.search(r'public class \w+ : Form',s):continue
 name=re.findall(r'\(\(Control\)this\)\.Name = "([^"]+)"',s)
 title=re.findall(r'\(\(Control\)this\)\.Text = "([^"]*)"',s)
 size=re.findall(r'ClientSize = new Size\((\d+), (\d+)\)',s)
 rows.append({'class':p.stem,'form':name[0] if name else None,'title':title[0] if title else None,'size':size[0] if size else None})
Path('analysis/forms.json').write_text(json.dumps(rows,ensure_ascii=False,indent=2))
for r in rows:print(r['class'],r['form'],r['title'])
print('Total:',len(rows))
