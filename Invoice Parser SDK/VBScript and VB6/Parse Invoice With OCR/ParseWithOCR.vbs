'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates the use of Optical Character Recognition (OCR) to parse invoice data 
' from scanned PDF documents and raster images.

inputDocument = "DigitalOcean-scanned.jpg"

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

