@echo off
setlocal
cd /d "%~dp0dotnet"
dotnet run --project FreeSms.Checks\FreeSms.Checks.csproj -c Release -- --root .. --integration
if errorlevel 1 goto failed
dotnet build FreeSms.Windows\FreeSms.Windows.csproj -c Release
if errorlevel 1 goto failed
dotnet FreeSms.Windows\bin\Release\net10.0-windows\FreeSMS.dll --verify-forms
if errorlevel 1 goto failed
echo Core, database and Windows form checks passed.
pause
exit /b 0
:failed
echo Verification failed. See the error above.
pause
exit /b 1
