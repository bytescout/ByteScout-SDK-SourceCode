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
