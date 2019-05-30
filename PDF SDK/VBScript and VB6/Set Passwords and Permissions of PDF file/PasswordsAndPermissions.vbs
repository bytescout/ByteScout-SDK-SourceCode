'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' This example demonstrates how to lock the document with a password. 
' PDF format supports two kinds of passwords: owner and user password.
' User password allows to view document and perform allowed actions.
' Owner password allows everything, including changing passwords and permissions.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Create document
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)
' or load existing one:
'pdfDocument.Load "c:\test\some-document.pdf"


' Set document encryption algorythm
pdfDocument.Security.EncryptionAlgorithm = comHelpers.ENCRYPTIONALGORITHM_RC4_40BIT
' Set various user permissions
pdfDocument.Security.AllowPrintDocument = False
pdfDocument.Security.AllowContentExtraction = False
pdfDocument.Security.AllowModifyAnnotations = False
pdfDocument.Security.PrintQuality = comHelpers.PRINTQUALITY_LOWRESOLUTION

' Set owner password
pdfDocument.Security.OwnerPassword = "ownerpassword"

' Set user password
pdfDocument.Security.UserPassword = "userpassword"

' Save protected document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
