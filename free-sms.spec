from pathlib import Path

root = Path(SPECPATH)
analysis = Analysis(
    [str(root / 'native/main.py')],
    pathex=[str(root / 'native')],
    binaries=[],
    datas=[
        (str(root / 'native/assets'), 'native/assets'),
        (str(root / 'analysis/sql-resources'), 'analysis/sql-resources'),
        (str(root / 'original/installed/db'), 'original/installed/db'),
        (str(root / 'original/update/rpt'), 'original/update/rpt'),
    ],
    hiddenimports=[],
    hookspath=[],
    hooksconfig={},
    runtime_hooks=[],
    excludes=[],
    noarchive=False,
)
pyz = PYZ(analysis.pure)
exe = EXE(
    pyz,
    analysis.scripts,
    [],
    exclude_binaries=True,
    name='FreeSMS',
    console=False,
    icon=str(root / 'native/assets/app.ico'),
)
coll = COLLECT(exe, analysis.binaries, analysis.datas, name='FreeSMS')
