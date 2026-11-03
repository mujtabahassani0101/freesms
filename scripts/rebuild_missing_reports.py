"""Use an intact original annual card for resources absent from the EXE.

No new presentation is generated. The absent catalog-specific RPTs have not
been recovered; these byte-preserving aliases are recorded explicitly.
"""
import hashlib
import json
from pathlib import Path

ROOT = Path(__file__).resolve().parent.parent
LAYOUTS = ROOT / 'dotnet/FreeSms.Original.Windows/portable-layouts'
SOURCE = 'CR_AF_StdKarnameDorehByChart_term3.rpt.xml'
ALIASES = ('CStdKarnameDorehByChart', 'CStdKarnameDorehByChart_byBestStd_OneMark')
payload = (LAYOUTS / SOURCE).read_bytes()
manifest = []
for name in ALIASES:
    marker = (' recovered-alias="' + name + '"').encode()
    alias = payload.replace(b'<report type=', b'<report' + marker + b' type=', 1)
    target = LAYOUTS / (name + '.rpt.xml')
    target.write_bytes(alias)
    manifest.append({'name': name, 'layout': str(target.relative_to(ROOT)),
                     'source': SOURCE, 'source_sha256': hashlib.sha256(payload).hexdigest(),
                     'scope': 'Unmodified original Afghan annual card. The absent catalog-specific RPT and exact appearance are not recovered.'})
(ROOT / 'validation/functional/rebuilt-reports.json').write_text(json.dumps(manifest, indent=2) + '\n')
print('Replaced two composed cards with byte-preserving aliases of the original annual card.')
