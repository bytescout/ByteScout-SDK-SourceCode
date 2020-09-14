@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: MakeSearchablePDF.bat file_name
	echo Example: MakeSearchablePDF.bat "sample_ocr.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\MakeSearchablePDF.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause