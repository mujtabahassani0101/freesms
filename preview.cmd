@echo off
call "%~dp0run.cmd" --preview %*
exit /b %errorlevel%
