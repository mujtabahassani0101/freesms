@echo off
setlocal
cd /d "%~dp0"
if not exist ".venv\Scripts\python.exe" (
  echo Run setup-python.cmd first.
  pause
  exit /b 1
)
docker info --format "{{.OSType}}" 2>nul | findstr /x "linux" >nul
if errorlevel 1 (
  echo Start Docker Desktop in Linux containers mode, then try again.
  pause
  exit /b 1
)
".venv\Scripts\python.exe" -X utf8 native\main.py %*
if errorlevel 1 (
  pause
  exit /b 1
)
