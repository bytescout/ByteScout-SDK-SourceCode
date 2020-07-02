'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' This example demonstrates how to save and restore the graphics state.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' If you wish to load an existing document uncomment the line below And comment the Add page section instead
' pdfDocument.Load("existing_document.pdf")

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Keep current graphics state
canvas.SaveGraphicsState()

' Transform coordinates and draw rectangle
canvas.TranslateTransform 200, 200
canvas.RotateTransform 45
Set blueBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255))
canvas.DrawRectangle_2 (blueBrush), 0, 0, 100, 100

' Restore the state and draw the same rectangle
canvas.RestoreGraphicsState()
Set redBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
canvas.DrawRectangle_2 (redBrush), 200, 200, 100, 100

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
