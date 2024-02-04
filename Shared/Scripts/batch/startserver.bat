@echo off
setlocal enableextensions

cd "%USERPROFILE%\Documents\projects\aspnetcore\LCPCollection"
dotnet watch run --project "Server"

pause
exit /b %errorlevel%
endlocal