'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create and activate TextRecognizer object
Set textRecognizer = CreateObject("ByteScout.TextRecognition.TextRecognizer")
textRecognizer.RegistrationName = "demo"
textRecognizer.RegistrationKey = "demo"

inputDocument = "skewed.png"
outputDocument = "result.txt"

' Load document (image or PDF)
textRecognizer.LoadDocument(inputDocument)

' Set the location of OCR language data files
textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\"

' Set OCR language.
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
' Find more language files at https://github.com/bytescout/ocrdata
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

