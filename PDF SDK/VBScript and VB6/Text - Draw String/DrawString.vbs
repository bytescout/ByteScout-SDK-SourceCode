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


' This example demonstrates how to draw a text.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Draw simple text
Set font = comHelpers.CreateSystemFont("Arial", 24)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
page1.Canvas.DrawString "Simple text.", (font), (blackBrush), 20, 20

' Draw text with alignment in specified rectangle
Set stringFormat = comHelpers.CreateStringFormat()
stringFormat.HorizontalAlign = comHelpers.HORIZONTALALIGN_RIGHT
stringFormat.VerticalAlign = comHelpers.VERTICALALIGN_BOTTOM
page1.Canvas.DrawString_7 "Aligned text", (font), (blackBrush), 20, 100, 200, 60, (stringFormat)
page1.Canvas.DrawRectangle comHelpers.CreateSolidPen(comHelpers.CreateColorGray(0), 1.0), 20, 100, 200, 60

' Draw colored text
Set boldFont = comHelpers.CreateSystemFont2("Arial", 32, True, False, False, False)
Set redBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
Set bluePen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 255), 1.0)
page1.Canvas.DrawString "Colored text", (boldFont), (redBrush), 20, 200
page1.Canvas.DrawString_3 "Outlined colored text", (boldFont), (redBrush), (bluePen), 20, 240
page1.Canvas.DrawString_2 "Outlined transparent text", (boldFont), (bluePen), 20, 280

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
