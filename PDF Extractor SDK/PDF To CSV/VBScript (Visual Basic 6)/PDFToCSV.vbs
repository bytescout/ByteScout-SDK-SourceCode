'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.CSVExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.CSVExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"

'extractor.CSVSeparatorSymbol = "," ' you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales

extractor.SaveCSVToFile "output.csv"

MsgBox "Data has been extracted to 'output.csv' file."

