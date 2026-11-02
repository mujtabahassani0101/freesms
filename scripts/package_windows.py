"""Package the source and the self-contained .NET Windows release, excluding local state."""
from pathlib import Path
import hashlib
import json
import shutil
import struct
import zipfile

ROOT = Path(__file__).resolve().parents[1]
RELEASE = ROOT / 'dist/FreeSMS-Net10'
SOURCE_ZIP = ROOT / 'FreeSMS-Windows-Source.zip'
RELEASE_ZIP = ROOT / 'FreeSMS-Net10-Windows-x64.zip'
EXCLUDE = {'.venv', '.tools', '.runtime', '.git', 'bin', 'obj', 'build', 'dist', '__pycache__', 'dotnet-data'}


def digest(path):
    with path.open('rb') as stream:
        return hashlib.file_digest(stream, 'sha256').hexdigest()


def zip_files(destination, files, directory, prefix):
    with zipfile.ZipFile(destination, 'w', zipfile.ZIP_DEFLATED, compresslevel=6) as archive:
        for path in files:
            archive.write(path, prefix + '/' + path.relative_to(directory).as_posix())
    with zipfile.ZipFile(destination) as archive:
        assert archive.testzip() is None


def ready_to_run(path):
    data = path.read_bytes()
    pe = struct.unpack_from('<I', data, 0x3c)[0]
    machine, sections = struct.unpack_from('<HH', data, pe + 4)
    optional_size = struct.unpack_from('<H', data, pe + 20)[0]
    optional = pe + 24
    magic = struct.unpack_from('<H', data, optional)[0]
    cli_rva = struct.unpack_from('<I', data, optional + (112 if magic == 0x20b else 96) + 14 * 8)[0]
    def offset(rva):
        for i in range(sections):
            section = optional + optional_size + i * 40
            size, address, raw_size, raw = struct.unpack_from('<IIII', data, section + 8)
            if address <= rva < address + max(size, raw_size):
                return raw + rva - address
        raise ValueError('RVA outside PE sections')
    native_rva, native_size = struct.unpack_from('<II', data, offset(cli_rva) + 64)
    return {'machine': hex(machine), 'ready_to_run': native_size > 0 and data[offset(native_rva):offset(native_rva)+4] == b'RTR\0'}


if __name__ == '__main__':
    assert (RELEASE / 'FreeSMS.exe').read_bytes()[:2] == b'MZ'
    report = {name: ready_to_run(RELEASE / name) for name in ['FreeSMS.dll', 'FreeSms.Core.dll']}
    assert all(item['ready_to_run'] and item['machine'] == '0x8664' for item in report.values())
    (ROOT / 'validation/dotnet-release.json').write_text(json.dumps(report, indent=2), encoding='utf-8')
    for name, text in {
        'Run.cmd': '@echo off\ncd /d "%~dp0"\n"%~dp0FreeSMS.exe" %*\n',
        'Preview.cmd': '@echo off\ncd /d "%~dp0"\n"%~dp0FreeSMS.exe" --preview %*\n'
    }.items():
        (RELEASE / name).write_bytes(text.replace('\n', '\r\n').encode('ascii'))
    shutil.copy2(ROOT / 'README.md', RELEASE / 'README-FA.md')
    licenses = RELEASE / 'licenses'
    licenses.mkdir(exist_ok=True)
    package_root = ROOT / '.tools/nuget'
    for package, version in [('microsoft.netcore.app.runtime.win-x64', '10.0.14'), ('microsoft.windowsdesktop.app.runtime.win-x64', '10.0.14')]:
        for source in (package_root / package / version).glob('*'):
            if source.is_file() and ('LICENSE' in source.name or 'THIRD-PARTY-NOTICES' in source.name):
                shutil.copy2(source, licenses / (package + '-' + source.name))
    for source in (ROOT / 'dotnet/FreeSms.Windows/obj').glob('project.assets.json'):
        assets = json.loads(source.read_text(encoding='utf-8'))
        inventory = []
        for name, item in assets['libraries'].items():
            if item.get('type') == 'package':
                directory = package_root / item['path']
                inventory.append({'package': name, 'repository': 'https://www.nuget.org/packages/' + name})
                for notice in directory.glob('*'):
                    if notice.is_file() and notice.name.upper().startswith(('LICENSE', 'THIRD-PARTY', 'NOTICE')):
                        shutil.copy2(notice, licenses / (name.replace('/', '-') + '-' + notice.name))
        (licenses / 'packages.json').write_text(json.dumps(inventory, indent=2), encoding='utf-8')
    for cache in ROOT.rglob('__pycache__'):
        if '.tools' not in cache.relative_to(ROOT).parts:
            shutil.rmtree(cache)
    source_files = sorted(p for p in ROOT.rglob('*') if p.is_file()
        and not EXCLUDE.intersection(p.relative_to(ROOT).parts)
        and p.suffix not in {'.zip', '.pyc'}
        and p.name not in {'SOURCE-MANIFEST.json', 'SHA256SUMS.txt'})
    manifest = ROOT / 'SOURCE-MANIFEST.json'
    manifest.write_text(json.dumps({'format': 2, 'target': 'net10.0-windows / win-x64', 'files': [
        {'path': p.relative_to(ROOT).as_posix(), 'bytes': p.stat().st_size, 'sha256': digest(p)} for p in source_files
    ]}, ensure_ascii=False, indent=2), encoding='utf-8')
    zip_files(SOURCE_ZIP, source_files + [manifest], ROOT, 'free-sms')
    zip_files(RELEASE_ZIP, sorted(p for p in RELEASE.rglob('*') if p.is_file()), RELEASE, 'FreeSMS-Net10')
    (ROOT / 'SHA256SUMS.txt').write_text(''.join(digest(p) + '  ' + p.name + '\n' for p in [SOURCE_ZIP, RELEASE_ZIP]), encoding='ascii')
    for path in [SOURCE_ZIP, RELEASE_ZIP]:
        print(path.name, path.stat().st_size, 'bytes')
