@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: PDFToXLSX.bat file_name
	echo Example: PDFToXLSX.bat "sample3.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\PDFToXLSX.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause