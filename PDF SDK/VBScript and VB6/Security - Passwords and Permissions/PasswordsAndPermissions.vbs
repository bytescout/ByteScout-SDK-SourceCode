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


' This example demonstrates how to lock the document with a password. 
' PDF format supports two kinds of passwords: owner and user password.
' User password allows to view document and perform allowed actions.
' Owner password allows everything, including changing passwords and permissions.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

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

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
