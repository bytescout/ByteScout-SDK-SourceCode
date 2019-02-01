@echo off
REM Run VBScript through the command line
REM The script convert first pages of all PDF documents in the outer folder containing sample files (..\..) 
REM   and puts generated images to "output" sub-folder.
cscript.exe "PDF_to_Image.vbs" ..\.. output

pause