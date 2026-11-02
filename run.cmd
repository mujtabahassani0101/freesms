@echo off
setlocal
cd /d "%~dp0"
if not exist "dist\FreeSMS-Native-Compatible\FreeSMS.exe" (
  echo Run setup.cmd first, or extract the complete native Windows release.
  pause
  exit /b 1
)
"%~dp0dist\FreeSMS-Native-Compatible\FreeSMS.exe" %*
exit /b %errorlevel%
