@echo off
setlocal enableextensions

cd "%USERPROFILE%\Documents\projects\aspnetcore\LCPCollection"
dotnet watch run --project "Client"

pause
exit /b %errorlevel%
endlocal