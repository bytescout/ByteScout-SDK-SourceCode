@echo off

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ConvertPdfToJpegFromUrl.ps1"
echo Script finished with errorlevel=%errorlevel%

pause