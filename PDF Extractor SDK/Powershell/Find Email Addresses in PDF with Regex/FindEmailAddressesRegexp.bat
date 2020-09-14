@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: FindEmailAddressesRegexp.bat file_name
	echo Example: FindEmailAddressesRegexp.bat "samplePDF_EmailAddress.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\FindEmailAddressesRegexp.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause