@echo off
setlocal
cd /d "%~dp0"
where py >nul 2>nul
if errorlevel 1 (
  echo Install Python 3.14 64-bit with the Python launcher, then run setup-python.cmd again.
  pause
  exit /b 1
)
py -3.14 -c "import struct,sys; sys.exit(0 if struct.calcsize('P') == 8 else 1)"
if errorlevel 1 (
  echo Python 3.14 64-bit is required.
  pause
  exit /b 1
)
if not exist ".venv\Scripts\python.exe" (
  py -3.14 -m venv .venv
  if errorlevel 1 goto failed
)
".venv\Scripts\python.exe" -m pip install --only-binary=:all: -r requirements.txt
if errorlevel 1 goto failed
echo Setup complete. Use run-python.cmd or preview-python.cmd.
pause
exit /b 0
:failed
echo Setup failed. See the error above.
pause
exit /b 1
