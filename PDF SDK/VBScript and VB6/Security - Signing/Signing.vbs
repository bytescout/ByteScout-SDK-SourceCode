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


' This example demonstrates how to digitally sign PDF document.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add sample page content
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
Set font = comHelpers.CreateSystemFont("Arial", 24)
Set stringFormat = comHelpers.CreateStringFormat()
stringFormat.HorizontalAlign = comHelpers.HORIZONTALALIGN_CENTER
page1.Canvas.DrawString_7 "Signature Test", (font), (brush), 0, 50, page1.Width, 100, (stringFormat)

' Signing parameters
certficateFile = "demo_certificate.pfx"
certficatePassword = "123"
' Optional parameters
signingReason = "Approval"
contactName = "John Smith"
location = "Corporate HQ"

' Invisible signature
'pdfDocument.Sign(certficateFile, certficatePassword)

' Visible signature
pdfDocument.Sign_2 certficateFile, certficatePassword, 400, 50, 150, 100, signingReason, contactName, location

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer application
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
