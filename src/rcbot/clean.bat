@echo off
del "transit" /f 2> nul
del "transit_operator.exe" /f 2> nul
del "token.json" /f 2> nul
del "package-lock.json" /f 2> nul
rmdir "node" /s /q 2> nul
rmdir "node_modules" /s /q 2> nul
rmdir ".vscode" /s /q 2> nul
echo.
pause