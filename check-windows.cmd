@echo off
setlocal
cd /d "%~dp0dotnet"
dotnet run --project FreeSms.Checks\FreeSms.Checks.csproj -c Release -- --root .. --integration
if errorlevel 1 goto failed
dotnet run --project FreeSms.ReportChecks\FreeSms.ReportChecks.csproj -c Release -- ..
if errorlevel 1 goto failed
dotnet run --project FreeSms.NativeChecks\FreeSms.NativeChecks.csproj -c Release -- ..
if errorlevel 1 goto failed
"%~dp0dist\FreeSMS-Net10\FreeSMS.exe" --verify-original-forms
if errorlevel 1 goto failed
"%~dp0dist\FreeSMS-Net10\FreeSMS.exe" --verify-native-startup
if errorlevel 1 goto failed
echo Native database, original forms and native startup checks passed.
pause
exit /b 0
:failed
echo Verification failed. Build the complete .NET 10 Windows application first.
pause
exit /b 1
