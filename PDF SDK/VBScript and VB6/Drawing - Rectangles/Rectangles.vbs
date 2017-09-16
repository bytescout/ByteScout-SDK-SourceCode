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


' This example demonstrates how to draw rectangles.

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
Set borderPen = comHelpers.CreateSolidPen(comHelpers.CreateColorGray(128), 2.0)
Set brush1 = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
Set brush2 = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 255, 255))

' Draw transparent rectangle with border only
canvas.DrawRectangle (borderPen), 100, 100, 100, 50

' Draw rounded rectangle with broder and filling
canvas.DrawRoundedRectangle_3 (borderPen), (brush1), 250, 100, 100, 50, 10

' Draw rectangle as polygon
Set pointsArray = comHelpers.CreatePointsArray(Array(Array(400, 100), Array(500, 100), Array(500, 150), Array(400, 150)))
canvas.DrawPolygon_3 (borderPen), (brush2), (pointsArray)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
