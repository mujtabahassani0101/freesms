@echo off
setlocal
cd /d "%~dp0"
if exist "dist\FreeSMS-Net10\FreeSMS.exe" (
  "dist\FreeSMS-Net10\FreeSMS.exe" %*
  exit /b
)
if not exist "dotnet\FreeSms.Windows\bin\Release\net10.0-windows\FreeSMS.dll" (
  echo Run setup.cmd first, or extract the Windows release to dist\FreeSMS-Net10.
  pause
  exit /b 1
)
dotnet "dotnet\FreeSms.Windows\bin\Release\net10.0-windows\FreeSMS.dll" %*
if errorlevel 1 (
  pause
  exit /b 1
)
