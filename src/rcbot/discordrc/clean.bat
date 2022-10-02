@echo off
del "transit_to" /f 2> nul
del "transit_from" /f 2> nul
del "discordrc_transit_dummy.exe" /f 2> nul
del "discordrc_transit_operator.exe" /f 2> nul
del "libgcc_s_dw2-1.dll" /f 2> nul
del "libstdc++-6.dll" /f 2> nul
del "package-lock.json" /f 2> nul
rmdir "@logs" /s /q 2> nul
rmdir "@settings" /s /q 2> nul
rmdir "node" /s /q 2> nul
rmdir "node_modules" /s /q 2> nul
rmdir ".vscode" /s /q 2> nul