@echo off
setlocal
cd /d "%~dp0dotnet"
dotnet run --project FreeSms.Checks\FreeSms.Checks.csproj -c Release -- --root .. --integration
if errorlevel 1 goto failed
"%~dp0dist\FreeSMS-Original-Net10\school_Af.exe" --verify-original-forms
if errorlevel 1 goto failed
"%~dp0dist\FreeSMS-Original-Net10\report-host\FreeSms.ReportHost.exe" --verify-engine
if errorlevel 1 goto failed
echo Native database, original forms and report template checks passed.
pause
exit /b 0
:failed
echo Verification failed. Build the full release and install the report runtime first.
pause
exit /b 1
