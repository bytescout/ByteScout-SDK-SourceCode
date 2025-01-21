'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.DocumentSplitter object
Set splitter = CreateObject("Bytescout.PDFExtractor.DocumentSplitter")
splitter.RegistrationName = "demo"
splitter.RegistrationKey = "demo"

inputFile = "sample2.pdf"

' Enable splitted parts optimization (remove unused resources)
splitter.OptimizeSplittedDocuments = true


' Extract a single page:
' ======================

splitter.ExtractPage inputFile, "page3.pdf", 3 ' (!) Note: page number is 1-based.
                
WScript.Echo "Extracted page #3 to file 'page3.pdf'."


' Split in two parts:
' ===================

splitter.Split inputFile, "part1.pdf", "part2.pdf", 3 ' (!) Note: page number is 1-based.

WScript.Echo "Splitted at page #3 to files 'part1.pdf' and 'part2.pdf'."


' Split by ranges:
' ================

' SplitCOM() returns array with file names. Files are saved to the system temporary directory.
Dim outFiles
outFiles = splitter.SplitCOM(inputFile, "1-3,4-") ' (!) Note: page numbers are 1-based; the ending "-" means "to the end".

Dim fileNames
For each of in outFiles
    fileNames = fileNames & of & vbCRLF
Next

WScript.Echo "Splitted by ranges to files: " & vbCRLF & fileNames
