@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: ExtractArabicText.bat file_name
	echo Example: ExtractArabicText.bat "sample_english_arabic.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ExtractArabicText.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause