@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: MergeAllDocumentsWithinFolder.bat folder_name
	echo Example: MergeAllDocumentsWithinFolder.bat "PDFDocs"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\MergeAllDocumentsWithinFolder.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause