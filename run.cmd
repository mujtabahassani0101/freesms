@echo off
setlocal
cd /d "%~dp0"
if not exist "dist\FreeSMS-Net10\FreeSMS.exe" (
  echo Run setup.cmd first, or extract the complete native Windows release.
  pause
  exit /b 1
)
"%~dp0dist\FreeSMS-Net10\FreeSMS.exe" %*
exit /b %errorlevel%
