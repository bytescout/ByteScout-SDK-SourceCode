'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to save and restore the graphics state.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

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
