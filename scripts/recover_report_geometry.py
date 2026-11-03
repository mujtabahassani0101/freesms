"""Restore omitted drawing properties from the original Crystal RAS extraction.

Usage: python scripts/recover_report_geometry.py /path/to/report-analysis/output
This reads existing analysis data only; the application has no Crystal dependency.
"""
import hashlib
import json
from pathlib import Path
import sys
import xml.etree.ElementTree as ET

ROOT = Path(__file__).resolve().parent.parent
source = Path(sys.argv[1])
namespace = '{http://www.crystaldecisions.com/report}'
result = ET.Element('geometry')
manifest = []

def recover(data, target):
    ras = ET.fromstring(data['layout_xml'])
    for area in ras.findall(namespace + 'Areas/' + namespace + 'Area'):
        sections = area.findall(namespace + 'Sections/' + namespace + 'Section')
        if not sections:
            continue
        for flag, section in (('NewPageBefore', sections[0]), ('NewPageAfter', sections[-1])):
            if area.findtext(namespace + 'Format/' + namespace + flag) == 'true':
                node = ET.SubElement(target, 'section', name=section.findtext(namespace + 'Name'))
                ET.SubElement(ET.SubElement(node, 'area-format'), 'Enable' + flag).text = 'true'
    for obj in ras.iter(namespace + 'ReportObject'):
        name = obj.findtext(namespace + 'ObjectName')
        properties = {}
        for key in ('EndSectionName', 'Right', 'Bottom', 'ExtendToBottomOfSection'):
            value = obj.findtext(namespace + key)
            if value is not None:
                properties[key] = value
        rotation = obj.findtext(namespace + 'ObjectFormat/' + namespace + 'TextRotationAngle')
        if rotation not in (None, 'Rotate0'):
            properties['TextRotationAngle'] = rotation
        if properties:
            node = ET.SubElement(target, 'object', name=name)
            for key, value in properties.items():
                ET.SubElement(node, key).text = value
    for name, child in data.get('subreports', {}).items():
        if child.get('layout_xml'):
            recover(child, ET.SubElement(target, 'subreport', name=name))

for path in sorted(source.glob('*.rpt.json')):
    report_type = path.name.removesuffix('.rpt.json')
    if not (ROOT / 'dotnet/FreeSms.Original.Windows/portable-layouts' / (report_type.split('.')[-1] + '.rpt.xml')).exists():
        continue
    recover(json.loads(path.read_text()), ET.SubElement(result, 'report', type=report_type))
    manifest.append({'source': path.name, 'sha256': hashlib.sha256(path.read_bytes()).hexdigest()})
ET.indent(result, space='  ')
ET.ElementTree(result).write(ROOT / 'dotnet/FreeSms.Reports/RecoveredGeometry.xml', encoding='utf-8', xml_declaration=True)
(ROOT / 'validation/functional/recovered-geometry-sources.json').write_text(json.dumps(manifest, indent=2) + '\n')
print(f'Recovered original shape anchors/rotation from {len(manifest)} reports.')
