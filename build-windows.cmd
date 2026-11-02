@echo off
setlocal
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0scripts\build-original-windows.ps1"
if errorlevel 1 (
  echo Build failed. See the error above.
  pause
  exit /b 1
)
echo Build complete: dist\FreeSMS-Original-Net10\school_Af.exe
pause
