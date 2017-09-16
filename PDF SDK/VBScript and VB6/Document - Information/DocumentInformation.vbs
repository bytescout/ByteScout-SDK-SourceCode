'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


' This example demonstrates how to set various document properties.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Change document information.
' Open Document Properties in PDF viewer to see the changes.
pdfDocument.DocumentInfo.Author = "John Doe"
pdfDocument.DocumentInfo.Creator = "My Application"
pdfDocument.DocumentInfo.Keywords = "accounting,invoice"
pdfDocument.DocumentInfo.Title = "Invoice #12345"
pdfDocument.DocumentInfo.Subject = "Invoice"
pdfDocument.DocumentInfo.CreationDate = CDate("2015-12-21")
pdfDocument.DocumentInfo.ModificationDate = Now

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
