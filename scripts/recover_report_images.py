"""Offline recovery of original RPT bitmaps; not needed to build or run the app.
Requires olefile and Pillow in the recovery environment. Matches only a unique
bitmap aspect ratio against the original engine's exported image dimensions.
"""
from pathlib import Path
import argparse
import base64
import hashlib
import io
import xml.etree.ElementTree as ET
import olefile
from PIL import Image

ROOT = Path(__file__).resolve().parents[1]


def recover(write=False):
    changed = []
    count = 0
    for path in sorted((ROOT / 'dotnet/FreeSms.Original.Windows/portable-layouts').glob('*.xml')):
        tree = ET.parse(path)
        objects = [obj for obj in tree.getroot().iter('object') if obj.findtext('Kind') == 'PictureObject']
        if not objects:
            continue
        source = ROOT / 'dotnet/FreeSms.Original.Windows' / (tree.getroot().get('type') + '.rpt')
        candidates = {}
        with olefile.OleFileIO(str(source)) as document:
            for stream in document.listdir():
                if len(stream) < 2 or stream[-1].lower() != 'contents':
                    continue
                data = document.openstream(stream).read()
                if not data.startswith(b'BM'):
                    continue
                digest = hashlib.sha256(data).hexdigest()
                with Image.open(io.BytesIO(data)) as original:
                    encoded = io.BytesIO()
                    original.save(encoded, format='PNG')
                    candidates[digest] = (original.width / original.height, encoded.getvalue(), '/'.join(stream))
        for obj in objects:
            ratio = float(obj.get('original-width')) / float(obj.get('original-height'))
            matches = [(digest, value) for digest, value in candidates.items() if abs(value[0] / ratio - 1) < .01]
            if len(matches) != 1:
                raise ValueError(f'Image cannot be matched uniquely: {path.name}/{obj.findtext("Name")}')
            digest, (_, payload, stream) = matches[0]
            for old in obj.findall('picture'):
                obj.remove(old)
            image = ET.SubElement(obj, 'picture', {'source-sha256': digest, 'source-stream': stream, 'encoding': 'png'})
            image.text = base64.b64encode(payload).decode('ascii')
            count += 1
        changed.append((path, tree))
    if count != 58:
        raise ValueError(f'Expected 58 original report images, matched {count}')
    if write:
        for path, tree in changed:
            tree.write(path, encoding='utf-8', xml_declaration=True)
    print(f'Matched {count} images in {len(changed)} templates; ' + ('saved.' if write else 'no files changed.'))


if __name__ == '__main__':
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--write', action='store_true')
    recover(parser.parse_args().write)
