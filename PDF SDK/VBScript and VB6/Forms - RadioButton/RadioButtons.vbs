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


' This example demonstrates how to create radio buttons.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 12)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Add a group of radio buttons
Set radioButton1 = comHelpers.CreateRadioButton(20, 20, 15, 15, "group1", "value1")
Set radioButton2 = comHelpers.CreateRadioButton(20, 40, 15, 15, "group1", "value2")
page1.Annotations.Add(radioButton1)
page1.Annotations.Add(radioButton2)
' Add labels
page1.Canvas.DrawString "Value 1.1", (timesFont), (blackBrush), 40, 20
page1.Canvas.DrawString "Value 1.2", (timesFont), (blackBrush), 40, 40

' Add another independent group of radio buttons
Set radioButton3 = comHelpers.CreateRadioButton(120, 20, 15, 15, "group2", "value3")
Set radioButton4 = comHelpers.CreateRadioButton(120, 40, 15, 15, "group2", "value4")
page1.Annotations.Add(radioButton3)
page1.Annotations.Add(radioButton4)
' Add labels
page1.Canvas.DrawString "Value 2.1", (timesFont), (blackBrush), 140, 20
page1.Canvas.DrawString "Value 2.2", (timesFont), (blackBrush), 140, 40

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
