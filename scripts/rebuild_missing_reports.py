"""Reconstruct two catalog layouts absent from the original executable.

Keep the recovered mark tables/formulas and best-student subreports intact.
Compose native chart bands from the corresponding recovered Afghan report.
This generates new layouts; it does not claim recovery of missing original RPTs.
"""
from copy import deepcopy
import hashlib
import json
from pathlib import Path
import xml.etree.ElementTree as ET

ROOT = Path(__file__).resolve().parent.parent
LAYOUTS = ROOT / 'dotnet/FreeSms.Original.Windows/portable-layouts'
DONOR = 'CR_AF_StdKarnameDorehByChart_term3.rpt.xml'
BASES = {'CStdKarnameDorehByChart': 'CStdKarnameDoreh3.rpt.xml',
         'CStdKarnameDorehByChart_byBestStd_OneMark': 'CStdKarnameDoreh_byBestStd_OneMark.rpt.xml'}

def set_text(node, key, value):
    child = node.find(key)
    if child is None:
        child = ET.SubElement(node, key)
    child.text = str(value)

def geometry(obj, left, top, width, height):
    for key, value in zip(('Left', 'Top', 'Width', 'Height'), (left, top, width, height)):
        set_text(obj, key, value)

def label(formula, name):
    obj = ET.Element('object')
    for key, value in [('Name', name), ('Kind', 'FieldObject'), ('Color', '-16777216')]:
        set_text(obj, key, value)
    geometry(obj, 210, 20, 10800, 360)
    ET.SubElement(obj, 'Font', family='Tahoma', size='10', style='1')
    fmt = ET.SubElement(obj, 'format')
    set_text(fmt, 'HorizontalAlignment', 'RightAlign')
    ET.SubElement(obj, 'source', name=name, formula=formula, kind='FormulaField')
    return obj

def add_formula(root, name, expression):
    formulas = root.find('formulas')
    if not any(f.get('name') == name for f in formulas):
        ET.SubElement(formulas, 'formula', name=name).text = expression

source = ET.parse(LAYOUTS / DONOR).getroot()
donor_band = source.find("./sections/section[@name='GroupFooterSection5']")
manifest = []
for name, base in BASES.items():
    root = ET.parse(LAYOUTS / base).getroot()
    root.set('type', 'FreeSms.Rebuilt.' + name)
    root.set('reconstruction', 'native-chart-composition-v1')
    root.set('reconstructed-from', base + ';' + DONOR)
    # Preserve all existing base formulas; copy only the missing chart expressions.
    for key in ('lesson', 'markchart', 'avgClass', 'examchart'):
        add_formula(root, key, source.find("./formulas/formula[@name='" + key + "']").text)
    add_formula(root, 'nativeCourseCaption', "'مقایسهٔ نمرهٔ مضمون شاگرد و اوسط صنف در ' + {spRpt_StdKarnameDoreh1.Exam}")
    add_formula(root, 'nativeChartStudent', "'شاگرد: ' + {spRpt_StdKarnameDoreh1.FName} + ' - ' + {spRpt_StdKarnameDoreh1.LName}")
    parameter = 'Pm-@xstudent'
    if not any(p.get('name').lower() == parameter.lower() for p in root.findall('./parameters/parameter')):
        ET.SubElement(root.find('parameters'), 'parameter', name=parameter, type='NumberField')
    # Replace the cramped inherited identity header in these reconstructed cards.
    # One growable multi-line field avoids clipping long student/father names.
    add_formula(root, 'nativeIdentity', "'مکتب: ' + {?sch} + '\nشاگرد: ' + {spRpt_StdKarnameDoreh1.FName} + '\nولد / بنت: ' + {spRpt_StdKarnameDoreh1.LName} + '\nولدیت: ' + {spRpt_StdKarnameDoreh1.PName} + '\nکد متعلم: ' + ToText({spRpt_StdKarnameDoreh1.Code},0,'')")
    class_exam = "'پایه: ' + {spRpt_StdKarnameDoreh1.Paye} + '    صنف: ' + {spRpt_StdKarnameDoreh1.Class} + '\nکارنامه: ' + {spRpt_StdKarnameDoreh1.Exam}"
    if root.find("./formulas/formula[@name='DateFrom']") is not None:
        class_exam += " + '\n' + {@DateFrom}"
    add_formula(root, 'nativeClassExam', class_exam)
    sections = root.find('sections')
    headings = sections.find("section[@name='GroupHeaderSection3']")
    for heading in headings.findall('object'):
        if heading.findtext('Kind') in ('TextObject', 'FieldHeadingObject'):
            set_text(heading, 'Height', max(900, int(heading.findtext('Height', '0'))))
    identity = sections.find("section[@name='GroupHeaderSection2']")
    photo = deepcopy(next(obj for obj in identity.findall('object') if obj.findtext('Name') == 'Studentimg1'))
    for obj in identity.findall('object'):
        identity.remove(obj)
    identity.set('height', '1700')
    geometry(photo, 210, 100, 1100, 1400)
    identity.append(photo)
    details = label('{@nativeIdentity}', 'NativeStudentIdentity')
    geometry(details, 1600, 20, 9000, 1600)
    set_text(details.find('format'), 'EnableCanGrow', 'true')
    identity.append(details)
    position = list(sections).index(identity) + 1
    for offset, (key, formula, size) in enumerate((('NativeClassExamHeader', '{@nativeClassExam}', 850), ('NativeAdditionalHeader', '{?heder2}', 450))):
        band = ET.Element('section', name=key, kind='GroupHeader', height=str(size + 50), **{'group-level':'1'})
        obj = label(formula, key + 'Text')
        geometry(obj, 210, 0, 10390, size)
        set_text(obj.find('format'), 'EnableCanGrow', 'true')
        band.append(obj)
        sections.insert(position + offset, band)
    # A recovered student footer can break before the new chart bands. Move the
    # student boundary after the complete reconstructed card instead.
    for band in sections.findall('section'):
        if band.get('kind') == 'GroupFooter' and band.get('group-level') == '1':
            flag = band.find('./format/EnableNewPageAfter')
            if flag is not None and flag.text == 'true':
                flag.text = 'false'
    # Insert chart bands within the student's group, before the outer class footer.
    insert = next(i for i, band in enumerate(sections) if band.get('kind') == 'GroupFooter' and band.get('group-level') == '0')
    course = ET.Element('section', name='NativeCourseComparison', kind='GroupFooter', height='3200', **{'group-level':'1'})
    course.append(label('{@nativeChartStudent}', 'NativeCourseStudent'))
    title = deepcopy(next(o for o in donor_band.findall('object') if o.findtext('Name') == 'examchart1'))
    geometry(title, 210, 410, 10800, 360)
    title.find('source').set('formula', '{@nativeCourseCaption}')
    course.append(title)
    chart = deepcopy(next(o for o in donor_band.findall('object') if o.find('chart') is not None))
    geometry(chart, 210, 850, 10800, 2200)
    chart.find('chart').set('show-values', 'true')
    for series, caption in zip(chart.findall('./chart/series'), ('نمرهٔ شاگرد', 'اوسط صنف')):
        series.set('label', caption)
    course.append(chart)
    sections.insert(insert, course)
    progress = ET.Element('section', name='NativeStudentProgress', kind='GroupFooter', height='3700', **{'group-level':'1'})
    progress.append(label('{@nativeChartStudent}', 'NativeProgressStudent'))
    child = deepcopy(donor_band.find("object[@subreport='Sub1']"))
    geometry(child, 210, 500, 10800, 3100)
    set_text(child.find('format'), 'EnableSuppress', 'false')
    child_report = child.find('report')
    # Retain selection, linked student parameter, database fields, groups, formulas
    # and chart series; remove empty legacy bands and use a readable native layout.
    legacy_sections = child_report.find('sections')
    graph = deepcopy(legacy_sections.find(".//object[Kind='ChartObject']"))
    geometry(graph, 0, 650, 10800, 2200)
    graph.find('chart').set('show-values', 'true')
    for series, caption in zip(graph.findall('./chart/series'), ('اوسط شاگرد', 'اوسط صنف')):
        series.set('label', caption)
    native_sections = ET.Element('sections')
    band = ET.SubElement(native_sections, 'section', name='NativeProgressPlot', kind='GroupHeader', height='3000', **{'group-level':'0'})
    for i, text in enumerate(('پیشرفت اوسط شاگرد', 'مقایسهٔ اوسط شاگرد و اوسط صنف در دوره‌ها')):
        obj = ET.SubElement(band, 'object'); set_text(obj, 'Name', 'NativeProgressTitle' + str(i)); set_text(obj, 'Kind', 'TextObject'); set_text(obj, 'Text', text)
        geometry(obj, 0, i * 300, 10800, 300)
        ET.SubElement(obj, 'Font', family='Tahoma', size='10', style='0')
        set_text(ET.SubElement(obj, 'format'), 'HorizontalAlignment', 'HorizontalCenterAlign')
    band.append(graph)
    child_report.remove(legacy_sections); child_report.append(native_sections)
    progress.append(child)
    progress_format = ET.SubElement(progress, 'format')
    ET.SubElement(progress_format, 'condition', name='EnableNewPageAfter').text = 'not OnLastRecord'
    sections.insert(insert + 1, progress)
    ET.indent(root, space='  ')
    target = LAYOUTS / (name + '.rpt.xml')
    ET.ElementTree(root).write(target, encoding='utf-8', xml_declaration=True)
    manifest.append({'name': name, 'layout': str(target.relative_to(ROOT)), 'source_sha256': {file: hashlib.sha256((LAYOUTS/file).read_bytes()).hexdigest() for file in (base,DONOR)},
                     'scope': 'Base table/formulas and existing best-student subreports preserved; native course comparison and linked student-progress chart added.'})
(ROOT/'validation/functional/rebuilt-reports.json').write_text(json.dumps(manifest, ensure_ascii=False, indent=2)+'\n')
print('Reconstructed', len(manifest), 'missing native report layouts; recovered source layouts unchanged.')
