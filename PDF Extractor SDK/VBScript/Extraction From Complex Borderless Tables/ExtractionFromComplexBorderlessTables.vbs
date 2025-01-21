'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.CSVExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.CSVExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "borderless_table.pdf"

' Set extraction columns explicitly.
' Coordinates in CustomExtractionColumns must match the left edges of the columns.
' To get coordinates in PDF points you can use PDF Multitool application 
' installed with the SDK. It shows mouse cursor coodinates in PDF points in the toolbar.
Dim coordinates
coordinates = Array(0, 124.5, 185, 241)

extractor.SetCustomExtractionColumns(coordinates)

extractor.SaveCSVToFile "output.csv"

WScript.Echo "Extracted data saved to 'output.csv' file."
