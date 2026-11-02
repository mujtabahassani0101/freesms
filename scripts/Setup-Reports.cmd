@echo off
setlocal
msiexec.exe /i "%~dp0CRRedist2005_x86.msi" /passive /norestart
exit /b %errorlevel%
