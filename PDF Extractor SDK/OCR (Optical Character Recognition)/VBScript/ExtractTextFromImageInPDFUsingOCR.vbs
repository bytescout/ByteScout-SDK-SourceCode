'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample_ocr.pdf")


' Enable Optical Character Recognition (OCR)
extractor.OCRMode = 1 ' OCRMode.Auto = 1

' Set the location of "tessdata" folder containing language data files
extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout BarCode SDK\Redistributable\tessdata"
			
' Set OCR language
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "tessdata" folder.
extractor.OCRLanguage = "eng"  

' Set PDF document rendering resolution
extractor.OCRResolution = 300

' Save extracted text to file
extractor.SaveTextToFile("output.txt")

MsgBox "Text was extracted to output.txt"

Set extractor = Nothing

