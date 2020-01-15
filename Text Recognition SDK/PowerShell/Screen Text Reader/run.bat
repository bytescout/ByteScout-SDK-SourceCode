@echo off

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ScreenTextReader.ps1"
echo Script finished with errorlevel=%errorlevel%

pause