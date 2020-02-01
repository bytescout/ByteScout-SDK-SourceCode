'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' This example demonstrates parsing of scanned documents
' using the Optical Character Recognition (OCR).

template = "..\..\_Sample Templates\DigitalOcean.yml"
inputDocument = "..\..\DigitalOcean-scanned.jpg"


' Create and activate DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Enable Optical Character Recognition (OCR) in Auto mode
' (DocumentParser automatically detects if OCR Is required).
documentParser.OCRMode = 1 ' OCRMode.Auto

' Set PDF document rendering resolution
documentParser.OCRResolution = 300

' Set the location of OCR language data files
documentParser.OCRLanguageDataFolder = "c:\Program Files\ByteScout Document Parser SDK\ocrdata"

' Set OCR language
' "eng" for english, "deu" for German, "fra" for French, etc. - according to files in "ocrdata" folder
documentParser.OCRLanguage = "eng"
' Find more language files at https://github.com/bytescout/ocrdata

' Note: The OCRLanguage can be overridden in a template. 
' See the Template Creation Guide.



' You can also apply various preprocessing filters
' to improve the recognition on low-quality scans.

' Automatically deskew skewed scans
'documentParser.OCRImagePreprocessingFilters.AddDeskew()

' Remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
'documentParser.OCRImagePreprocessingFilters.AddVerticalLinesRemover()
'documentParser.OCRImagePreprocessingFilters.AddHorizontalLinesRemover()

' Repair broken letters
'documentParser.OCRImagePreprocessingFilters.AddDilate()

' Remove noise
'documentParser.OCRImagePreprocessingFilters.AddMedian()

' Apply Gamma Correction
'documentParser.OCRImagePreprocessingFilters.AddGammaCorrection(1.4)

' Add Contrast
'documentParser.OCRImagePreprocessingFilters.AddContrast(20)



' Load template
documentParser.AddTemplate(template)

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "output.json", 0 ' 0 = OutputFormat.JSON

WScript.Echo "Parsed data saved as 'output.json'"

Set documentParser = Nothing

