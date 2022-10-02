@echo off
powershell -command ""node\node.exe" "main.js" /e | tee-object ".logs\.log@debug.log""
pause