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


' Create Bytescout.PDFExtractor.JSONExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.JSONExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"

' Add the following params to get clean data with word nodes only:
extractor.DetectNewColumnBySpacesRatio = 0.1 ' This splits all text into words
extractor.PreserveFormattingOnTextExtraction = false ' Get rid of empty nodes

extractor.SaveJSONToFile "output.json"

WScript.Echo "Extracted data saved to 'output.json' file."
