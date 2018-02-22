@echo off

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\GeneralExample.ps1"
echo Script finished with errorlevel=%errorlevel%

pause