'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.SearchablePDFMaker object
Set searchablePDFMaker = CreateObject("Bytescout.PDFExtractor.SearchablePDFMaker")
searchablePDFMaker.RegistrationName = "demo"
searchablePDFMaker.RegistrationKey = "demo"

' Load sample PDF document
searchablePDFMaker.LoadDocumentFromFile("sample_ocr_withText.pdf")

' Set the location of OCR language data files
searchablePDFMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best"
			
' Set OCR language
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder.
searchablePDFMaker.OCRLanguage = "eng"  
' Find more language files at https://github.com/bytescout/ocrdata

' Set PDF document rendering resolution
searchablePDFMaker.OCRResolution = 300

' Discard Existing Text in document
searchablePDFMaker.DiscardExistingDocumentText = true

' Process the document
searchablePDFMaker.MakePDFSearchable("result.pdf")

WScript.Echo "Searchable document saved as 'result.pdf'."
