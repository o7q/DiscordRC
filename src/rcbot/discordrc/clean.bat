@echo off
del "rcbot_transit_dummy.exe" /f 2> nul
del "rcbot_transit_operator.exe" /f 2> nul
del "transit_to" /f 2> nul
del "transit_from" /f 2> nul
del "_start_debug.bat" /f 2> nul
del "package-lock.json" /f 2> nul
rmdir "_logs" /s /q 2> nul
rmdir "_settings" /s /q 2> nul
rmdir "node" /s /q 2> nul
rmdir "node_modules" /s /q 2> nul
rmdir ".vscode" /s /q 2> nul