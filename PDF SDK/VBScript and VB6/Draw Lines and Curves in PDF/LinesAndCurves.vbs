'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to draw lines and curves.

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
