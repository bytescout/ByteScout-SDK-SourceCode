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


' This example demonstrates how to use coordinate space transformations.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Prepare pens
Set blackPen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 0), 2.0)
blackPen.Opacity = 50
Set bluePen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 255), 2.0)
bluePen.Opacity = 50
Set greenPen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 255, 0), 2.0)
greenPen.Opacity = 50

' Move coordinate space zero point to (200, 200) and draw a rectangle of 50x50 dize
canvas.TranslateTransform 200, 200
canvas.DrawRectangle (blackPen), 0, 0, 50, 50

' Now zoom the coordinate space in twice and draw the same rectangle in green
canvas.ScaleTransform 2, 2
canvas.DrawRectangle (greenPen), 0, 0, 50, 50

' Now rotate the coordinate space by 30 degrees and draw the same rectangle in blue
canvas.RotateTransform 30
canvas.DrawRectangle (bluePen), 0, 0, 50, 50

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
