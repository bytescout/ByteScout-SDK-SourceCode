'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' This example demonstrates how to add JavaScript actions to document events.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add action to document open event
Set onOpenDocument = comHelpers.CreateJavaScriptAction("app.alert(""OnOpenDocument"",3)")
pdfDocument.OnOpenDocument = onOpenDocument

' Add action to document close event
Set onBeforeClosing = comHelpers.CreateJavaScriptAction("app.alert(""OnBeforeClosing"",3)")
pdfDocument.OnBeforeClosing = onBeforeClosing

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
