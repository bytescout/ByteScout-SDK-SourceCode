'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates the use of OCR Analyser - a tooling class for analysis of scanned documents
' in PDF or raster image formats to find best parameters for Optical Character Recognition (OCR) that
' provide highest recognition quality.


' Input document
inputDocument = "sample_ocr.pdf"

' Document page index
pageIndex = 0

' Location of OCR language data files
ocrLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

' OCR language
ocrLanguage = "eng" ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
' Find more language files at https://github.com/bytescout/ocrdata


' Create OCRAnalyzer object and activate it with your registration information
Set ocrAnalyzer = CreateObject("Bytescout.PDFExtractor.OCRAnalyzer")
ocrAnalyzer.RegistrationName = "demo"
ocrAnalyzer.RegistrationKey = "demo"

' Load document to OCRAnalyzer
ocrAnalyzer.LoadDocumentFromFile(inputDocument)

' Setup OCRAnalyzer
ocrAnalyzer.OCRLanguage = ocrLanguage
ocrAnalyzer.OCRLanguageDataFolder = ocrLanguageDataFolder

WScript.Echo "Starting the OCR analysis. Click OK and wait, it may last long." & outputDocument

' Perform analysis and get results
Set analysisResults = ocrAnalyzer.AnalyzeByOCRConfidence(pageIndex)


' Now extract page text using detected OCR parameters

outputDocument = ".\result.txt"

' Create TextExtractor object
Set textExtractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
textExtractor.RegistrationName = "demo"
textExtractor.RegistrationKey = "demo"

' Load document to TextExtractor
textExtractor.LoadDocumentFromFile(inputDocument)

' Setup TextExtractor
textExtractor.OCRMode = 1 ' OCRMode.Auto
textExtractor.OCRLanguageDataFolder = ocrLanguageDataFolder
textExtractor.OCRLanguage = ocrLanguage

' Apply analysys results to TextExtractor instance
ocrAnalyzer.ApplyResults (analysisResults), (textExtractor)

' Save extracted text to file
textExtractor.SaveTextToFile(outputDocument)


WScript.Echo "Extracted text saved to " & outputDocument


Set textExtractor = Nothing
Set ocrAnalyzer = Nothing

