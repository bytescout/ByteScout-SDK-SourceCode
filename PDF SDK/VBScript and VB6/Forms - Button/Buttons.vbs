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


' This example demonstrates how to create a button and decorate it.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Create a button
Set button1 = comHelpers.CreatePushButton(50, 50, 100, 30, "button1")
button1.Caption = "Button"
' Decorate the button with various styles
button1.BackgroundColor = comHelpers.CreateColorRGB(192, 192, 255)
button1.BorderWidth = 2
button1.BorderStyle = comHelpers.BORDERSTYLE_BEVELED
button1.BorderColor = comHelpers.CreateColorRGB(0, 0, 128)
button1.Font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 16)
button1.FontColor = comHelpers.CreateColorRGB(0, 0, 0)
button1.HighlightingMode = comHelpers.PUSHBUTTONHIGHLIGHTINGMODE_OUTLINE

' Add button to the page
page1.Annotations.Add(button1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
