@echo off
setlocal
cd /d "%~dp0dotnet"
dotnet run --project FreeSms.Checks\FreeSms.Checks.csproj -c Release -- --root .. --integration
if errorlevel 1 goto failed
"%~dp0dist\FreeSMS-Native-Compatible\FreeSMS.exe" --verify-original-forms
if errorlevel 1 goto failed
"%~dp0dist\FreeSMS-Native-Compatible\FreeSMS.exe" --verify-native-startup
if errorlevel 1 goto failed
echo Native database, original forms and native startup checks passed.
pause
exit /b 0
:failed
echo Verification failed. Build the full release and install the report runtime first.
pause
exit /b 1
