@echo off

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ImagePreprocessingFilters.ps1"
echo Script finished with errorlevel=%errorlevel%

pause