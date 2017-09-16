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


' This example demonstrates how to create a listbox.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add list box, add items and make it multi-selectable
Set listBox1 = comHelpers.CreateListBox(20, 20, 120, 80, "listBox1")
listBox1.Items.Add("Value 1")
listBox1.Items.Add("Value 2")
listBox1.Items.Add("Value 3")
listBox1.Items.Add("Value 4")
listBox1.Items.Add("Value 5")
listBox1.MultiSelect = True
' Decorate listbox
listBox1.Font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_HELVETICA, 10)
listBox1.FontColor = comHelpers.CreateColorRGB(0, 0, 128)
listBox1.BorderColor = comHelpers.CreateColorRGB(0, 0, 128)
listBox1.BackgroundColor = comHelpers.CreateColorRGB(240, 240, 255)
listBox1.BorderWidth = 2

page1.Annotations.Add(listBox1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
