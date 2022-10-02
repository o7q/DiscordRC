@echo off
g++ "..\$SharedIcon\icon.res" *.cpp -Wall -O2 -o "discordrc_transit_operator.exe"
echo.
pause