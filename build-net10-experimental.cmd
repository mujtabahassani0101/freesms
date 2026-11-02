@echo off
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0scripts\build-original-windows.ps1"
exit /b %errorlevel%
