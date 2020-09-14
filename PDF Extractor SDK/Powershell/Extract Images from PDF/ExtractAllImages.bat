@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: ExtractAllImages.bat file_name
	echo Example: ExtractAllImages.bat "sample1.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ExtractAllImages.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause