@echo off
setlocal enableextensions

cd "%USERPROFILE%\Documents\projects\aspnetcore\LCPCollection"
dotnet watch run --project "Auth"

pause
exit /b %errorlevel%
endlocal