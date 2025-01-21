'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to draw right-to-left text.

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

' Set right to left text direction
Set stringFormat = comHelpers.CreateStringFormat()
stringFormat.DirectionRightToLeft = True

page1.Canvas.DrawString_4 "???? ????? ?????", (font), (brush), page1.Width - 20, 30, (stringFormat)
page1.Canvas.DrawString_4 "???, ?????, ????", (font), (brush), page1.Width - 20, 50, (stringFormat)
page1.Canvas.DrawString_4 "?? ?? ??", (font), (brush), page1.Width - 20, 70, (stringFormat)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
