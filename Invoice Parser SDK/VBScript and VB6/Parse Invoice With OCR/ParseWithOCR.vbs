'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' This example demonstrates the use of Optical Character Recognition (OCR) to parse invoice data 
' from scanned PDF documents and raster images.

inputDocument = "..\..\DigitalOcean-scanned.jpg"

' Create InvoiceParser object
Set invoiceParser = CreateObject("Bytescout.InvoiceParser.InvoiceParser")
invoiceParser.RegistrationName = "demo"
invoiceParser.RegistrationKey = "demo"

' Enable Optical Character Recognition (OCR)
' in .Auto mode (SDK automatically checks if needs to use OCR or not)
invoiceParser.OCRMode = 1 ' OCRMode.Auto = 1

' Set the location of OCR language data files
invoiceParser.OCRLanguageDataFolder = "c:\Program Files\ByteScout Invoice Parser SDK\ocrdata"
			
' Set OCR language
' "eng" for english, "deu" for German, "fra" for French, etc. - according to files in "ocrdata" folder
invoiceParser.OCRLanguage = "eng"
' Find more language files at https://github.com/bytescout/ocrdata

' Parse invoice data in JSON format
invoiceParser.ParseDocument inputDocument, "output.json", 0 ' 0 = OutputFormat.JSON

WScript.Echo "Extracted text saved as 'output.json'."

Set invoiceParser = Nothing

