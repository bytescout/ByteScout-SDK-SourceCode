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


' This example demonstrates how to create a navigation link to a page.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add two pages
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)
Set page2 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page2)

Set font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 12)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Create link annotation pointing to Page 2, 200 Points from the top.
Set destination = comHelpers.CreateDestination((page2), 200)
Set link = comHelpers.CreateLinkAnnotation((destination), 20, 20, 100, 25)
link.Color = comHelpers.CreateColorRGB(255, 0, 0) ' you can change the link color
page1.Annotations.Add(link)

' Draw link text (optional)
Set stringFormat = comHelpers.CreateStringFormat()
stringFormat.HorizontalAlign = comHelpers.HORIZONTALALIGN_CENTER
stringFormat.VerticalAlign = comHelpers.VERTICALALIGN_CENTER
page1.Canvas.DrawString_7 "Link to Page 2", (font), (brush), 20, 20, 100, 25, (stringFormat)

' Draw a text at the link target
page2.Canvas.DrawString "Link target", (font), (brush), 20, 200

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
