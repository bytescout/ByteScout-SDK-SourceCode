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


' Create and activate TextRecognizer object
Set textRecognizer = CreateObject("ByteScout.TextRecognition.TextRecognizer")
textRecognizer.RegistrationName = "demo"
textRecognizer.RegistrationKey = "demo"

Set comHelpers = textRecognizer.ComHelpers

inputDocument = "..\..\areas-sample.pdf"
pageIndex = 0
outputDocument = "result.txt"

' Load document (image or PDF)
textRecognizer.LoadDocument(inputDocument)

' Set the location of OCR language data files
textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\"

' Set OCR language.
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
' Find more language files at https://github.com/bytescout/ocrdata
textRecognizer.OCRLanguage = "eng" 

' Get page size (in pixels). Size of PDF document is computed from PDF Points 
' and the rendering resoultion specified by `textRecognizer.PDFRenderingResolution` (default 300 DPI)
Dim pageWidth, pageHeight
pageWidth = textRecognizer.GetPageWidth(pageIndex)
pageHeight = textRecognizer.GetPageHeight(pageIndex)

' Add area of interest as a rectangle at the top-right corner of the page
textRecognizer.RecognitionAreas.Add pageWidth / 2, 0, pageWidth / 2, 300
' Add area of interest as a rectangle at the bottom-left corner of the page,
' and indicate it should be rotated at 90 deg
textRecognizer.RecognitionAreas.Add 0, pageHeight / 2, 300, pageHeight / 2, comHelpers.AreaRotation_Rotate90FlipNone

' Now you can get recognized text for further analysis as a list of objects 
' containing coordinates, object kind, confidence.
Set ocrObjectList = textRecognizer.GetOCRObjects(pageIndex)
For Each ocrObject in OCRObjectList
    WScript.Echo ocrObject.Text & " [" & ocrObject.X & ", " & ocrObject.Y & ", " & ocrObject.Width & ", " & ocrObject.Height & "] : " & ocrObject.Confidence
Next

' ... or you can save recognized text pieces to file
textRecognizer.KeepTextFormatting = False ' save without formatting
textRecognizer.SaveText outputDocument, pageIndex, pageIndex


WScript.Echo "Extracted text saved to " + outputDocument

Set recognizer = Nothing

