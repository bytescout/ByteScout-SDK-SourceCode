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


' Create and activate TextRecognizer object
Set textRecognizer = CreateObject("ByteScout.TextRecognition.TextRecognizer")
textRecognizer.RegistrationName = "demo"
textRecognizer.RegistrationKey = "demo"

inputDocument = "..\..\skewed.png"
outputDocument = "result.txt"

' Load document (image or PDF)
textRecognizer.LoadDocument(inputDocument)

' Set the location of "tessdata" folder containing language data files
textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\tessdata"
			
' Set OCR language.
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "tessdata" folder.
' Find more language files at https://github.com/tesseract-ocr/tessdata/tree/3.04.00
textRecognizer.OCRLanguage = "eng"


' Add deskew filter that automatically rotates the image to make the text horizontal.
' Note, it analyzes the left edge of scanned text. Any dark artifacts may prevent 
' the correct angle detection.
textRecognizer.ImagePreprocessingFilters.AddDeskew()

' Other filters that may be useful to improve recognition
' (note, the filters are applied in the order they were added):

' Improve image contrast.
'textRecognizer.ImagePreprocessingFilters.AddContrast()

' Apply gamma correction.
'textRecognizer.ImagePreprocessingFilters.AddGammaCorrection()

' Apply median filter. Helps to remove noise.
'textRecognizer.ImagePreprocessingFilters.AddMedian()

' Apply dilate filter. Helps to cure symbols erosion.
'textRecognizer.ImagePreprocessingFilters.AddDilate()

' Lines removers. Removing borders of some tables may improve the recognition.
'textRecognizer.ImagePreprocessingFilters.AddHorizontalLinesRemover()
'textRecognizer.ImagePreprocessingFilters.AddVerticalLinesRemover()


' Recognize text from all pages and save it to file
textRecognizer.SaveText(outputDocument)

WScript.Echo "Extracted text saved to " + outputDocument

Set recognizer = Nothing

