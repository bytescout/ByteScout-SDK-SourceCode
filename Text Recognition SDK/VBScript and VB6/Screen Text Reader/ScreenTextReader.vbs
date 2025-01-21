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

outputDocument = "result.txt"

' Create ScreenshotMaker object
Set screenshotMaker = CreateObject("ByteScout.TextRecognition.ScreenshotMaker")
' Set rectangle to take screenshot from
screenshotMaker.SetScreenshotArea 0, 0, 200, 200

' Load screenshot
textRecognizer.LoadDocument_4(screenshotMaker)

' Set the location of OCR language data files
textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\"

' Set OCR language.
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
' Find more language files at https://github.com/bytescout/ocrdata
textRecognizer.OCRLanguage = "eng" 

' Recognize text from all pages and save it to file
textRecognizer.SaveText(outputDocument)

WScript.Echo "Extracted text saved to " + outputDocument

Set recognizer = Nothing

