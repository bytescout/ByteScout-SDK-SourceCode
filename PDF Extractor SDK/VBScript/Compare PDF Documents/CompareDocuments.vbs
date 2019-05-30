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


' Create TextComparer object
Set comparer = CreateObject("Bytescout.PDFExtractor.TextComparer")
comparer.RegistrationName = "demo"
comparer.RegistrationKey = "demo"

'Compare documents
comparer.Compare "..\..\comparison1.pdf", "..\..\comparison2.pdf"

' Generate report
comparer.GenerateHtmlReport "report.html"

' Open output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "report.html", 1, false

