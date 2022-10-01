@echo off
powershell -command ""node\node.exe" "main.js" /e | tee-object ".logs\.log_debug.log""
pause