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
