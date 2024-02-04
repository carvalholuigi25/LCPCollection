@echo off
setlocal enableextensions

SET DEFOPTIONDBM=1
SET DBMode="SQLServer"
SET ASPNETCORE_ENVIRONMENT="Development"
SET MYLCPPATH="%USERPROFILE%\Documents\projects\aspnetcore\LCPCollection\Server"

cls
dotnet tool install --global dotnet-ef

if exist "%USERPROFILE%\LCPCollectionDB.mdf" ( 
	del /f /q "%USERPROFILE%\LCPCollectionDB.mdf"
)

if exist "%USERPROFILE%\LCPCollectionDB_log.ldf" (
	del /f /q "%USERPROFILE%\LCPCollectionDB_log.ldf"
)

if exist "%MYLCPPATH%\Migrations" ( 
	rd /s /q "%MYLCPPATH%\Migrations"
)

if exist "%MYLCPPATH%\Databases" ( 
	rd /s /q "%MYLCPPATH%\Databases"
)

if not exist "%MYLCPPATH%\Migrations" (
	mkdir "%MYLCPPATH%\Migrations"
)

if not exist "%MYLCPPATH%\Databases" (
	mkdir "%MYLCPPATH%\Databases"
)

if not exist "%MYLCPPATH%\Databases\SQLServer" (
	mkdir "%MYLCPPATH%\Databases\SQLServer"
)

if not exist "%MYLCPPATH%\Databases\SQLite" (
	mkdir "%MYLCPPATH%\Databases\SQLite"
)

if not exist "%MYLCPPATH%\Databases\PostgreSQL" (
	mkdir "%MYLCPPATH%\Databases\PostgreSQL"
)

cd "%MYLCPPATH%"

echo.
echo 1. SQL Server
echo 2. SQLite
echo 3. PostgreSQL
echo 4. MySQL
echo 5. All
echo.

set /P DBModeOpt="Choose the option [%DEFOPTIONDBM%]: "
if "%DBModeOpt%"=="" set "DBModeOpt=%DEFOPTIONDBM%"

if "%DBModeOpt%" == "1" (
	call :genDBSQLServer
) else if "%DBModeOpt%" == "2" (
	call :genDBSQLite
) else if "%DBModeOpt%" == "3" (
	call :genDBPostgreSQL
) else if "%DBModeOpt%" == "4" (
	call :genDBMySQL
) else (
	call :genDBAll
)

:genDBSQLServer
	SET DBMode="SQLServer"
	dotnet ef migrations remove --context DBContext --force
	dotnet ef migrations add InitialCreateSQLServer --context DBContext --output-dir "Migrations\SQLServer"
	dotnet ef database update --context DBContext

	call :copyfiles
goto:eof

:genDBSQLite
	SET DBMode="SQLite"
	dotnet ef migrations remove --context DBContextSQLite --force
	dotnet ef migrations add InitialCreateSQLite --context DBContextSQLite --output-dir "Migrations\SQLite"
	dotnet ef database update --context DBContextSQLite
goto:eof

:genDBPostgreSQL
	SET DBMode="PostgreSQL"
	dotnet ef migrations remove --context DBContextPostgreSQL --force
	dotnet ef migrations add InitialCreatePostgreSQL --context DBContextPostgreSQL --output-dir "Migrations\PostgreSQL"
	dotnet ef database update --context DBContextPostgreSQL
goto:eof

:genDBMySQL
	SET DBMode="MySQL"
	dotnet ef migrations remove --context DBContextMySQL --force
	dotnet ef migrations add InitialCreatePostgreSQL --context DBContextMySQL --output-dir "Migrations\MySQL"
	dotnet ef database update --context DBContextMySQL
goto:eof

:genDBAll
	dotnet ef migrations remove --context DBContext --force
	dotnet ef migrations remove --context DBContextSQLite --force
	dotnet ef migrations remove --context DBContextPostgreSQL --force
	dotnet ef migrations remove --context DBContextMySQL --force

	SET DBMode="SQLServer"
	dotnet ef migrations add InitialCreateSQLServer --context DBContext --output-dir "Migrations\SQLServer"
	dotnet ef database update --context DBContext

	SET DBMode="SQLite"
	dotnet ef migrations add InitialCreateSQLite --context DBContextSQLite --output-dir "Migrations\SQLite"
	dotnet ef database update --context DBContextSQLite

	SET DBMode="PostgreSQL"
	dotnet ef migrations add InitialCreatePostgreSQL --context DBContextPostgreSQL --output-dir "Migrations\PostgreSQL"
	dotnet ef database update --context DBContextPostgreSQL

	SET DBMode="MySQL"
	dotnet ef migrations add InitialCreatePostgreSQL --context DBContextMySQL --output-dir "Migrations\MySQL"
	dotnet ef database update --context DBContextMySQL

	call :copyfiles
goto:eof

:copyfiles
	if exist "%USERPROFILE%\LCPCollectionDB.mdf" (
		copy "%USERPROFILE%\LCPCollectionDB.mdf" "%MYLCPPATH%\Databases\SQLServer"
	)

	if exist "%USERPROFILE%\LCPCollectionDB_log.ldf" (
		copy "%USERPROFILE%\LCPCollectionDB_log.ldf" "%MYLCPPATH%\Databases\SQLServer"
	)
goto:eof

exit /b %errorlevel%
endlocal