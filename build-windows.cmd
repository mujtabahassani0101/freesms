@echo off
setlocal
cd /d "%~dp0dotnet"
dotnet publish FreeSms.Windows\FreeSms.Windows.csproj -c Release -r win-x64 --self-contained true -p:PublishReadyToRun=true -p:RestorePackagesPath="%~dp0.tools\nuget" -o "%~dp0dist\FreeSMS-Net10"
if errorlevel 1 (
  echo Build failed. See the error above.
  pause
  exit /b 1
)
echo Build complete: dist\FreeSMS-Net10\FreeSMS.exe
echo Copy the entire FreeSMS-Net10 directory to the destination computer.
pause
