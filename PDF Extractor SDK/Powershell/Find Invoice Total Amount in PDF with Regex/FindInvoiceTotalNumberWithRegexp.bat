@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: FindInvoiceTotalNumberWithRegexp.bat file_name
	echo Example: FindInvoiceTotalNumberWithRegexp.bat "SampleInvoice.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\FindInvoiceTotalNumberWithRegexp.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause