'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to use color profiles.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Load ICC color profile
Set iccProfile = comHelpers.CreateICCBasedColorspace("USWebCoatedSWOP.icc")
' Create profiled color brush
Set iccColor = comHelpers.CreateColorICC((iccProfile), comHelpers.CreateColorCMYK(0, 100, 0, 0))
Set iccBrush = comHelpers.CreateSolidBrush((iccColor))
' Draw a circle using the brush
page1.Canvas.DrawCircle_2 (iccBrush), 200, 200, 100

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
