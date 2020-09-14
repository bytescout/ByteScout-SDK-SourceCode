@echo off

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\MergeDocuments.ps1"
echo Script finished with errorlevel=%errorlevel%

pause