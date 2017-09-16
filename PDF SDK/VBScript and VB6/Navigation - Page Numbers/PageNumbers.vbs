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


' This example demonstrates how to add page numbers (labels) visible in the page thumbnails panel of PDF viewer.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add twenty pages
For i = 0 To 19
    pdfDocument.Pages.Add(comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4))
Next

' First five pages will have roman numbers I, II, III, ...
Set pageLabel = comHelpers.CreatePageLabel(0, comHelpers.PAGENUMBERINGSTYLE_UPPERCASEROMAN)
pdfDocument.PageLabels.Add(pageLabel)

' Next five pages will have arabic numbers 6, 7, 8, ...
pageLabel.Style = comHelpers.PAGENUMBERINGSTYLE_DECIMALARABIC
pageLabel.StartPortion = 6
pageLabel.FirstPageIndex = 5
pdfDocument.PageLabels.Add(pageLabel)

' Next five pages will have complex page numbers with prefix A-11, A-12, A-13, ...
pageLabel.Style = comHelpers.PAGENUMBERINGSTYLE_DECIMALARABIC
pageLabel.Prefix = "A-"
pageLabel.StartPortion = 11
pageLabel.FirstPageIndex = 10
pdfDocument.PageLabels.Add(pageLabel)

' Next five pages will use letters as page numbers P, Q, R, ...
pageLabel.Prefix = ""
pageLabel.Style = comHelpers.PAGENUMBERINGSTYLE_UPPERCASELETTERS
pageLabel.StartPortion = 16
pageLabel.FirstPageIndex = 15
pdfDocument.PageLabels.Add(pageLabel)

' Force PDF viewer to show page thumbnails panel on start up
pdfDocument.PageMode = comHelpers.PAGEMODE_THUMBNAIL

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
