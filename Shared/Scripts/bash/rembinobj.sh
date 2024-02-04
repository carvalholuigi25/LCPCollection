#!/bin/bash
clear

if [ -f "$HOME\Documents\projects\aspnetcore\LCPCollection\Client\bin" ]; then
	rm -rf "$HOME\Documents\projects\aspnetcore\LCPCollection\Client\bin"
fi

if [ -f "$HOME\Documents\projects\aspnetcore\LCPCollection\Client\obj" ]; then
	rm -rf "$HOME\Documents\projects\aspnetcore\LCPCollection\Client\obj"
fi

if [ -f "$HOME\Documents\projects\aspnetcore\LCPCollection\Server\bin" ]; then
	rm -rf "$HOME\Documents\projects\aspnetcore\LCPCollection\Server\bin"
fi

if [ -f "$HOME\Documents\projects\aspnetcore\LCPCollection\Server\obj" ]; then
	rm -rf "$HOME\Documents\projects\aspnetcore\LCPCollection\Server\obj"
fi

if [ -f "$HOME\Documents\projects\aspnetcore\LCPCollection\Shared\bin" ]; then
	rm -rf "$HOME\Documents\projects\aspnetcore\LCPCollection\Shared\bin"
fi

if [ -f "$HOME\Documents\projects\aspnetcore\LCPCollection\Shared\obj" ]; then
	rm -rf "$HOME\Documents\projects\aspnetcore\LCPCollection\Shared\obj"
fi

if [ -f "$HOME\Documents\projects\aspnetcore\LCPCollection\Auth\bin" ]; then
	rm -rf "$HOME\Documents\projects\aspnetcore\LCPCollection\Auth\bin"
fi

if [ -f "$HOME\Documents\projects\aspnetcore\LCPCollection\Auth\obj" ]; then
	rm -rf "$HOME\Documents\projects\aspnetcore\LCPCollection\Auth\obj"
fi

echo Cleaned up all files from obj and bin directories!

exit