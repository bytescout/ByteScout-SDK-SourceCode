'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to attach a file to PDF document.

' Open pdf document
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' Load existing document
pdfDocument.Load("Invoice.pdf")

Set comHelpers = pdfDocument.ComHelpers

' Attach ZUGFeRD XML file
Set fileAttachment = comHelpers.CreateFileAttachmentAnnotation("ZUGFeRD-invoice.xml", 0, 0, 0, 0)
pdfDocument.Pages.Item(0).Annotations.Add(fileAttachment)

' Instruct PDF viewer applications to show attachments pane on startup (optional)
pdfDocument.PageMode = comHelpers.PAGEMODE_ATTACHMENT

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
