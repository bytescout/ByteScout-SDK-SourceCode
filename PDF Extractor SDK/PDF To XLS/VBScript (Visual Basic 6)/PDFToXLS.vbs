'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.XLSExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XLSExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"

extractor.SaveToXLSFile "output.XLS"

MsgBox "Data has been extracted to 'output.XLS' file."

