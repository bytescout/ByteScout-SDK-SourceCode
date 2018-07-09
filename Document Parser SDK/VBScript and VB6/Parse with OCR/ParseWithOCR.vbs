'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


' This example demonstrates the use of Optical Character Recognition (OCR) to parse document 
' from scanned PDF documents and raster images.

inputDocument = "..\..\DigitalOcean-scanned.jpg"

' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Enable Optical Character Recognition (OCR)
' in .Auto mode (SDK automatically checks if needs to use OCR or not)
documentParser.OCRMode = 1 ' OCRMode.Auto = 1

' Set the location of "tessdata" folder containing language data files
documentParser.OCRLanguageDataFolder = "c:\Program Files\ByteScout Document Parser SDK\net40\tessdata"
			
' Set OCR language
documentParser.OCRLanguage = "eng"
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "tessdata" folder.
' Find more language files at https://github.com/tesseract-ocr/tessdata/tree/3.04.00

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "output.json", 0 ' 0 = OutputFormat.JSON

WScript.Echo "Extracted text saved as 'output.json'."

Set documentParser = Nothing

