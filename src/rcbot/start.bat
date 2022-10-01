@echo off
cd "discordrc" 2> nul
powershell -command ""node\node.exe" "main.js" /e | tee-object output"