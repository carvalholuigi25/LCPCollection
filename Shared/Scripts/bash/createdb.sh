#!/usr/bin/bash

DEFOPTIONDBM=1
DBMode="SQLServer"
ASPNETCORE_ENVIRONMENT="Development"
USERPTHCT="$HOME"
MYLCPPATH="$USERPTHCT/Documents/projects/aspnetcore/LCPCollection/Server"

clear
dotnet tool install --global dotnet-ef

if [[ -f "$USERPTHCT/LCPCollectionDB.mdf" ]]; then 
	rm -f "$USERPTHCT/LCPCollectionDB.mdf"
fi

if [[ -f "$USERPTHCT/LCPCollectionDB_log.ldf" ]]; then 
	rm -f "$USERPTHCT/LCPCollectionDB_log.ldf"
fi

if [[ -d "$MYLCPPATH/Migrations" ]]; then 
	rm -rf "$MYLCPPATH/Migrations"
fi

if [[ -d "$MYLCPPATH/Databases" ]]; then 
	rm -rf "$MYLCPPATH/Databases"
fi

if [[ ! -d "$MYLCPPATH/Migrations" ]]; then 
	mkdir -p "$MYLCPPATH/Migrations"
fi

if [[ ! -d "$MYLCPPATH/Databases" ]]; then 
	mkdir -p "$MYLCPPATH/Databases"
fi

if [[ ! -d "$MYLCPPATH/Databases/SQLite" ]]; then 
	mkdir -p "$MYLCPPATH/Databases/SQLite"
fi

if [[ ! -d "$MYLCPPATH/Databases/SQLServer" ]]; then 
	mkdir -p "$MYLCPPATH/Databases/SQLServer"
fi

if [[ ! -d "$MYLCPPATH/Databases/PostgreSQL" ]]; then 
	mkdir -p "$MYLCPPATH/Databases/PostgreSQL"
fi

if [[ ! -d "$MYLCPPATH/Databases/MySQL" ]]; then 
	mkdir -p "$MYLCPPATH/Databases/MySQL"
fi

cd "$MYLCPPATH"

echo
echo "1. SQL Server"
echo "2. SQLite"
echo "3. PostgreSQL"
echo "4. MySQL"
echo "5. All"
echo

read -p "Choose the option [$DEFOPTIONDBM]: " DBModeOpt
DBModeOpt="${DBModeOpt:-$DEFOPTIONDBM}"

if [[ $DBModeOpt == "1" ]]; then
	genDBSQLServer
elif [[ $DBModeOpt == "2" ]]; then
	genDBSQLite
elif [[ $DBModeOpt == "3" ]]; then
	genDBPostgreSQL
elif [[ $DBModeOpt == "4" ]]; then
	genDBMySQL
else
	genDBAll
fi

genDBSQLServer () {
	DBMode="SQLServer"
	dotnet ef migrations remove --context DBContext --force
	dotnet ef migrations add InitialCreateSQLServer --context DBContext --output-dir "Migrations\SQLServer"
	dotnet ef database update --context DBContext

	copyfiles
}

genDBSQLite () {
	DBMode="SQLite"
	dotnet ef migrations remove --context DBContextSQLite --force
	dotnet ef migrations add InitialCreateSQLite --context DBContextSQLite --output-dir "Migrations\SQLite"
	dotnet ef database update --context DBContextSQLite
}

genDBPostgreSQL () {
	DBMode="PostgreSQL"
	dotnet ef migrations remove --context DBContextPostgreSQL --force
	dotnet ef migrations add InitialCreatePostgreSQL --context DBContextPostgreSQL --output-dir "Migrations\PostgreSQL"
	dotnet ef database update --context DBContextPostgreSQL
}

genDBMySQL () {
	DBMode="MySQL"
	dotnet ef migrations remove --context DBContextMySQL --force
	dotnet ef migrations add InitialCreatePostgreSQL --context DBContextMySQL --output-dir "Migrations\MySQL"
	dotnet ef database update --context DBContextMySQL
}

genDBAll () {
	dotnet ef migrations remove --context DBContext --force
	dotnet ef migrations remove --context DBContextSQLite --force
	dotnet ef migrations remove --context DBContextPostgreSQL --force
	dotnet ef migrations remove --context DBContextMySQL --force

	DBMode="SQLServer"
	dotnet ef migrations add InitialCreateSQLServer --context DBContext --output-dir "Migrations\SQLServer"
	dotnet ef database update --context DBContext

	DBMode="SQLite"
	dotnet ef migrations add InitialCreateSQLite --context DBContextSQLite --output-dir "Migrations\SQLite"
	dotnet ef database update --context DBContextSQLite

	DBMode="PostgreSQL"
	dotnet ef migrations add InitialCreatePostgreSQL --context DBContextPostgreSQL --output-dir "Migrations\PostgreSQL"
	dotnet ef database update --context DBContextPostgreSQL
	
	DBMode="MySQL"
	dotnet ef migrations add InitialCreatePostgreSQL --context DBContextMySQL --output-dir "Migrations\MySQL"
	dotnet ef database update --context DBContextMySQL

	copyfiles
}

copyfiles () {
	if [[ -f "$USERPTHCT/LCPCollectionDB.mdf" ]]; then
		cp -r "$USERPTHCT/LCPCollectionDB.mdf" "$MYLCPPATH/Databases/SQLServer"
	fi

	if [[ -f "$USERPTHCT/LCPCollectionDB_log.ldf" ]]; then
		cp -r "$USERPTHCT/LCPCollectionDB_log.ldf" "$MYLCPPATH/Databases/SQLServer"
	fi
}

exit