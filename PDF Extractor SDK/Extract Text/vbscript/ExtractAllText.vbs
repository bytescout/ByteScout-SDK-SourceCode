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
extractor.LoadDocumentFromFile("..\..\sample.pdf")

' Save extracted text to file
extractor.SaveTextToFile("output.txt")

' Open output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "output.txt", 1, false
Set shell = Nothing

Set extractor = Nothing

