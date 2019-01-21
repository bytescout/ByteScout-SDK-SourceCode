@echo off

rem This command will convert XLS file to CSV with TAB delimiter.

"%PROGRAMFILES%\Bytescout Spreadsheet SDK\Console\Bytescout.Spreadsheet.Console.exe" ".\Input Files\sample.xls" /F CSV /O ".\Output Files" /D "\t"

pause