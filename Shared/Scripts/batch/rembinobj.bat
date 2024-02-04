@echo off
setlocal enableextensions
cls

if exist "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Client\bin" (
	rmdir /s /q "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Client\bin"
)

if exist "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Client\obj" (
	rmdir /s /q "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Client\obj"
)

if exist "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Server\bin" (
	rmdir /s /q "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Server\bin"
)

if exist "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Server\obj" (
	rmdir /s /q "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Server\obj"
)

if exist "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Shared\bin" (
	rmdir /s /q "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Shared\bin"
)

if exist "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Shared\obj" (
	rmdir /s /q "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Shared\obj"
)

if exist "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Auth\bin" (
	rmdir /s /q "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Auth\bin"
)

if exist "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Auth\obj" (
	rmdir /s /q "%userprofile%\Documents\projects\aspnetcore\LCPCollection\Auth\obj"
)

echo Cleaned up all files from obj and bin directories!

pause
exit /b %errorlevel%
endlocal