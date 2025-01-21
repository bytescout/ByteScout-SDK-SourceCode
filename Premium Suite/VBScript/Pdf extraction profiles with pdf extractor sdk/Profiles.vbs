'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates the use of profiles. Profiles are set of properties 
' allowing to apply them to Extractor in any combination quickly. You can use 
' predefined profiles or create you own in JSON format like in this example.

' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"
extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best"

' Load sample PDF document
extractor.LoadDocumentFromFile("sample_ocr.pdf")

' Apply predefined profiles
extractor.Profiles = "scanned, no-layout"
' Extract text to file
extractor.SaveTextToFile("result1.txt")


extractor.Reset


' Load another document
extractor.LoadDocumentFromFile("sample_ocr.pdf")

' Load and apply custom profiles
extractor.LoadProfiles("profiles.json")
extractor.Profiles = "keep-formatting, ocr-forced-200dpi"
' Extract text to file
extractor.SaveTextToFile("result2.txt")
