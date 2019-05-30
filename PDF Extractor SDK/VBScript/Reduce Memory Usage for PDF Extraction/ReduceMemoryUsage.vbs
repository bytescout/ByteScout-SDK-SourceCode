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


' When processing huge PDF documents you may run into OutOfMemoryException.
' This example demonstrates a way to spare the memory by disabling page data caching.
            
' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample2.pdf")

' Disable page data caching, so processed pages wiil be disposed automatically
extractor.PageDataCaching = 0 ' 0 - no caching; 1 - cache all pages.

' Save extracted text to file
extractor.SaveTextToFile("output.txt")

Set extractor = Nothing

WScript.Echo "Extracted data saved to 'output.txt' file."
