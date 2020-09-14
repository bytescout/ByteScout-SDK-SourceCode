@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: ExtractTextFromPageArea.bat file_name
	echo Example: ExtractTextFromPageArea.bat "sample2.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ExtractTextFromPageArea.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause