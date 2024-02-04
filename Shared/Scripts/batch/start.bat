@echo off
setlocal enableextensions

cd "%USERPROFILE%\Documents\projects\aspnetcore\LCPCollection"
start /d "." dotnet watch run --project "Client"
start /d "." dotnet watch run --project "Server"

pause
exit /b %errorlevel%
endlocal