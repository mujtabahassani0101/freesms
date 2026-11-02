@echo off
setlocal
cd /d "%~dp0"
if not exist ".venv\Scripts\python.exe" (
  echo Run setup-python.cmd first.
  pause
  exit /b 1
)
".venv\Scripts\python.exe" -m pip install -r requirements-build.txt
if errorlevel 1 goto failed
".venv\Scripts\python.exe" -m PyInstaller --noconfirm free-sms.spec
if errorlevel 1 goto failed
echo Build complete: dist\FreeSMS\FreeSMS.exe
echo Copy the entire dist\FreeSMS directory to the destination computer.
pause
exit /b 0
:failed
echo Build failed. See the error above.
pause
exit /b 1
