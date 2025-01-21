'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to load and modify an existing document.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

'  Load existing document
pdfDocument.Load("sample.pdf")
        
' Add new page to loaded document
Set newPage = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 24)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
newPage.Canvas.DrawString "New Page", (timesFont), (blackBrush), 20, 20
pdfDocument.Pages.Add(newPage)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
