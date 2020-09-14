@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: FindTableAndExtractAsCsv.bat file_name
	echo Example: FindTableAndExtractAsCsv.bat "sample3.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\FindTableAndExtractAsCsv.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause