'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.XFDFExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XFDFExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"

extractor.SaveXFDFToFile "output.xml"

MsgBox "Data has been extracted to 'output.xml' file."

