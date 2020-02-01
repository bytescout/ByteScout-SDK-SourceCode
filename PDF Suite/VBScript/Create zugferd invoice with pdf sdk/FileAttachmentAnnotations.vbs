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
