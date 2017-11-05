'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


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

