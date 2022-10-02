@echo off
g++ "..\$SharedIcon\icon.res" *.cpp -Wall -O2 -o "discordrc_transit_dummy.exe"
echo.
pause