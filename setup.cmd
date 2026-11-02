@echo off
setlocal
where dotnet >nul 2>nul
if errorlevel 1 goto missing
dotnet --list-sdks | findstr /b "10." >nul
if errorlevel 1 goto missing
call "%~dp0build-windows.cmd"
exit /b %errorlevel%
:missing
echo Install the .NET 10 SDK for Windows x64, then run setup.cmd again.
pause
exit /b 1
