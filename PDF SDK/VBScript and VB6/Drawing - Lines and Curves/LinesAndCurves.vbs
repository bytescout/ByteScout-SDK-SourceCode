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


' This example demonstrates how to draw lines and curves.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

Set blackPen = comHelpers.CreateSolidPen(comHelpers.CreateColorGray(0), 1)
Set dashedPen = comHelpers.CreateSolidPen(comHelpers.CreateColorGray(0), 1)
dashedPen.DashPattern = comHelpers.CreateDashPattern(Array(2.0, 2.0), 0)

' Draw dashed lines
canvas.DrawLine (dashedPen), 100, 100, 200, 100
canvas.DrawLine (dashedPen), 200, 100, 200, 200
canvas.DrawLine (dashedPen), 200, 200, 100, 200
' Draw besier curve by the same points
canvas.DrawCurve (blackPen), 100, 100, 200, 100, 200, 200, 100, 200

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
