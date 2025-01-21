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

inputFile = "sample.pdf"

' Enable optimization of output documents
splitter.OptimizeSplittedDocuments = true

splitter.ExtractPage inputFile, "page3.pdf", 3 ' (!) Note: page number is 1-based.
                
WScript.Echo "Extracted page 3 to file page3.pdf"

' Split in two parts:
' ===================

splitter.Split inputFile, "part1.pdf", "part2.pdf", 3 ' (!) Note: page number is 1-based.

WScript.Echo "Splitted at page 3 to files part1.pdf and part2.pdf"

' Split by ranges:
' ================

' SplitCOM() returns array with a list of filenames
splittedParts = splitter.SplitCOM(inputFile, "1-3,4-6,7,8-") ' (!) Note: page numbers are 1-based; ending "-" means "to the end".

WScript.Echo "Splitted by ranges sucessfully"

' Display list of generated outputfiles
For Each file in splittedParts
    Wscript.Echo file
Next
