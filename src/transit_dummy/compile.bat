@echo off
g++ *.cpp "..\_SharedIcon\transit\icon.res" -Wall -O2 -o "..\rcbot\discordrc\rcbot_transit_dummy.exe" -static-libstdc++ -static-libgcc
echo.
pause