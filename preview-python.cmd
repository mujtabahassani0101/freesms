@echo off
setlocal
cd /d "%~dp0"
if not exist ".venv\Scripts\python.exe" (
  echo Run setup-python.cmd first.
  pause
  exit /b 1
)
".venv\Scripts\python.exe" -X utf8 native\main.py --preview %*
if errorlevel 1 (
  pause
  exit /b 1
)
