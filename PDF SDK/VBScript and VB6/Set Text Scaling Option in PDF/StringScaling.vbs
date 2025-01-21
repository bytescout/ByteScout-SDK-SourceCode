'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to use the font scaling to expand a string.

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

Set font = comHelpers.CreateSystemFont("Arial", 16)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
Set stringFormat = comHelpers.CreateStringFormat()

stringFormat.Scaling = 100.0
page1.Canvas.DrawString_4 "Normal string 100.0%", (font), (brush), 20, 20, (stringFormat)

stringFormat.Scaling = 50.0
page1.Canvas.DrawString_4 "Squeezed string 50.0%", (font), (brush), 20, 50, (stringFormat)

stringFormat.Scaling = 150.0
page1.Canvas.DrawString_4 "Expanded string 150.0%", (font), (brush), 20, 80, (stringFormat)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
