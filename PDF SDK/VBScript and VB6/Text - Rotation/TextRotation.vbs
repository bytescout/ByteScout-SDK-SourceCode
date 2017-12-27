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

' Prepare font and brush
Set font = comHelpers.CreateSystemFont("Arial", 24)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

Set canvas = page1.Canvas

' Draw simple text
canvas.DrawString "Simple text.", (font), (blackBrush), 50, 100

' Save canvas state
canvas.SaveGraphicsState()

' Move canvas origin (0,0) point to (50,100)
canvas.TranslateTransform 50, 100

' Rotate canvas at 45 deg around of the origin point
canvas.RotateTransform 45 
canvas.DrawString "Rotated 45", (font), (blackBrush), 0, 0

' Rotate another 45 deg
canvas.RotateTransform 45 
canvas.DrawString "Rotated 90", (font), (blackBrush), 0, 0

' Restore canvas state to reset all transformations
canvas.RestoreGraphicsState()

' Save document
pdfDocument.Save("result.pdf")


' Save document to file
pdfDocument.Save("result.pdf")

' Open PDF document in default associated application (for demo puprpose)
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
