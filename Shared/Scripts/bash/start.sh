#!/bin/sh
clear
cd ../../../

dotnet run --project "Server" --no-build &
dotnet run --project "Client" --no-build &