'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


' This example demonstrates the use of Optical Character Recognition (OCR) to parse invoice 
' from scanned PDF documents and raster images.

inputDocument = "..\..\DigitalOcean-scanned.jpg"

' Create InvoiceParser object
Set invoiceParser = CreateObject("Bytescout.InvoiceParser.InvoiceParser")
invoiceParser.RegistrationName = "demo"
invoiceParser.RegistrationKey = "demo"

' Enable Optical Character Recognition (OCR)
' in .Auto mode (SDK automatically checks if needs to use OCR or not)
invoiceParser.OCRMode = 1 ' OCRMode.Auto = 1

' Set the location of "tessdata" folder containing language data files
invoiceParser.OCRLanguageDataFolder = "C:\Program Files\Bytescout PDF Extractor SDK\net4.00\tessdata"
			
' Set OCR language
invoiceParser.OCRLanguage = "eng"
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "tessdata" folder.
' Find more language files at https://github.com/tesseract-ocr/tessdata/tree/3.04.00

' Parse invoice data in JSON format
invoiceParser.ParseDocument inputDocument, "output.json", 0 ' 0 = OutputFormat.JSON

WScript.Echo "Extracted text saved as 'output.json'."

Set invoiceParser = Nothing

