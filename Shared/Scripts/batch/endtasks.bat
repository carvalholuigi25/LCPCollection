@echo off
setlocal enableextensions

taskkill /f /im dotnet.exe
taskkill /f /im perfwatson2.exe
taskkill /f /im vbcscompiler.exe

pause
exit /b %errorlevel%
endlocal