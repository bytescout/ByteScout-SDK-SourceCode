@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: PDFToJSONWithImages.bat file_name
	echo Example: PDFToJSONWithImages.bat "sample1.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\PDFToJSONWithImages.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause