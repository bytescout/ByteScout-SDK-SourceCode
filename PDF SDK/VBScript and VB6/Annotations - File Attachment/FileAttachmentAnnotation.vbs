'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' This example demonstrates how to attach a file to PDF document.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Attach file
Set fileAttachment = comHelpers.CreateFileAttachmentAnnotation("sample_attachment.txt", 20, 20, 20, 20)
fileAttachment.Icon = comHelpers.FILEATTACHMENTANNOTATIONICON_PAPERCLIP
page1.Annotations.Add(fileAttachment)

' Instruct PDF viewer application to show attachments pane on startup
pdfDocument.PageMode = comHelpers.PAGEMODE_ATTACHMENT

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
