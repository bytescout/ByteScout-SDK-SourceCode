@echo off

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ExtractFromAreas.ps1"
echo Script finished with errorlevel=%errorlevel%

pause