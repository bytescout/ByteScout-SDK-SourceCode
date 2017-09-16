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


' This example demonstrates how to create document outlines (bookmarks).

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

Set font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 18)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Create pages
For i = 0 To 2
    Set newPage = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
    newPage.Canvas.DrawString "Page " & (i + 1), (font), (brush), 20, 20
    pdfDocument.Pages.Add(newPage)
Next

' Create outlines:

Set destination1 = comHelpers.CreateDestination(pdfDocument.Pages.Item(0), 0)
Set outline1 = comHelpers.CreateOutline_2("Page 1", (destination1))
pdfDocument.Outlines.Add(outline1)

' Example of sub-bookmark
Set destination2 = comHelpers.CreateDestination(pdfDocument.Pages.Item(1), 0)
Set outline2 = comHelpers.CreateOutline_2("Page 2", (destination2))
pdfDocument.Outlines.Item(0).Kids.Add(outline2)

Set destination3 = comHelpers.CreateDestination(pdfDocument.Pages.Item(2), 0)
Set outline3 = comHelpers.CreateOutline_2("Page 3", (destination3))
pdfDocument.Outlines.Add(outline3)

' Force PDF viewer to show Bookmarks panel at start up.
pdfDocument.PageMode = comHelpers.PAGEMODE_OUTLINES

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
