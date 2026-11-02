@echo off
setlocal
cd /d "%~dp0"
if not exist "dist\FreeSMS-Original-Net10\school_Af.exe" (
  echo Run setup.cmd first, or extract the complete native Windows release.
  pause
  exit /b 1
)
"%~dp0dist\FreeSMS-Original-Net10\school_Af.exe" %*
exit /b %errorlevel%
