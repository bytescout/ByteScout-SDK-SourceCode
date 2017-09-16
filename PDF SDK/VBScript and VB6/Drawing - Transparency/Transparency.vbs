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


' This example demonstrates how to draw transparent objects.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Prepare pens and brushes
Set borderPen = comHelpers.CreateSolidPen(comHelpers.CreateColorGray(0), 2.0)

Set brush1 = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
Set brush2 = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255))

borderPen.Opacity = 50
brush1.Opacity = 30
brush2.Opacity = 60

' Draw normal rectangles
canvas.DrawRectangle_2 (brush1), 100, 100, 100, 100
canvas.DrawRectangle_3 (borderPen), (brush2), 150, 150, 100, 100

borderPen.Opacity = 80
brush1.Opacity = 60
brush2.Opacity = 30

' Draw rounded rectangles
canvas.DrawRoundedRectangle_2 (brush1), 220, 100, 100, 100, 10
canvas.DrawRoundedRectangle_3 (borderPen), (brush2), 270, 150, 100, 100, 10

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
