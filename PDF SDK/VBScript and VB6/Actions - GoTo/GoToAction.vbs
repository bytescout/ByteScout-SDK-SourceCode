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


' This example demonstrates how to create a button with GoTo action.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)
Set page2 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page2)

Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 18)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Mark action target with text
page2.Canvas.DrawString "Action target", (timesFont), (blackBrush), 20, 200

' Create button
Set button1 = comHelpers.CreatePushButton(20, 20, 100, 25, "button1")
button1.Caption = "Go To Page 2"

' Create action to go to page 2 at 200 points from the top
button1.OnActivated = comHelpers.CreateGoToAction(comHelpers.CreateDestination((page2), 200))

page1.Annotations.Add(button1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
