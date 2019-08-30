set current_dir=%CD%

@echo off

rem  This command will convert all files from "Input Files" directory to XLS format.
rem  Converter will use ";" delimiter when reading CSV and TXT files.

"%PROGRAMFILES%\Bytescout Spreadsheet SDK\Console\Bytescout.Spreadsheet.Console.exe" ".\Input Files\*.*" /F XLS /O ".\Output Files" /D ";"

pause