@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: PDFToXLS.bat file_name
	echo Example: PDFToXLS.bat "sample3.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\PDFToXLS.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause