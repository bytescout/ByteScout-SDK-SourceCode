'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\columns.pdf")

' read width of the very first page (zero index)
pageWidth = extractor.GetPageRect_Width (0)
pageHeight = extractor.GetPageRect_Height (0)

' now we are extracting content assuming we have 3 columns 
' equally distributed on pages

' first calculate the width of the one column by dividing page width by number of columns (3)
columnWidth = pageWidth / 3

' iterate through 3 columns
For i=0 to 2

' set the extraction area to the #i column 
extractor.SetExtractionArea i * columnWidth, 0, columnWidth , pageHeight

outFileName = "columns-column"& CStr(i) & ".txt"
extractor.SavePageTextToFile 0, outFileName

' Open output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run outFileName, 1, false
Set shell = Nothing

Next

Set extractor = Nothing

MsgBox "Done"
