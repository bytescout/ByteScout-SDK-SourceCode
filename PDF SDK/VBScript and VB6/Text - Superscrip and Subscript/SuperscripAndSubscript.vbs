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


' This example demonstrates how to create a document and save it to file.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set font = comHelpers.CreateSystemFont("Arial", 16)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
Set stringFormat = comHelpers.CreateStringFormat()
xPosition = 20

' Draw normal string
page1.Canvas.DrawString_4 "Normal text ", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Normal text ")

' Draw subscript string 
stringFormat.Rise = -5
page1.Canvas.DrawString_4 "Subscript", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Subscript")

' draw superscript string
stringFormat.Rise = +5
page1.Canvas.DrawString_4 "Superscript", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Superscript")

' Draw the baseline
Set pen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 255), 1.0)
pen.Opacity = 50
page1.Canvas.DrawLine (pen), 20, 50 + font.Size, xPosition, 50 + font.Size

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
