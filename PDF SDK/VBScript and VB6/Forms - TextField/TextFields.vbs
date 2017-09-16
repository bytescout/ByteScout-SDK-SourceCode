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


' This example demonstrates how text fields and theirs variations.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add simple text field with default properties
Set edit1 = comHelpers.CreateEditBox(20, 20, 120, 25, "editBox1")
edit1.Text = "One two three"
page1.Annotations.Add(edit1)

' Add password box
Set edit2 = comHelpers.CreateEditBox(20, 50, 120, 25, "editBox2")
edit2.Text = "password"
edit2.Password = True
page1.Annotations.Add(edit2)

' Add multiline text field
Set edit3 = comHelpers.CreateEditBox(20, 80, 120, 50, "editBox3")
edit3.Multiline = True
edit3.Text = "The quick brown fox jumps over, the lazy dog."
page1.Annotations.Add(edit3)

' Demonstrate various decoration properties 
Set edit4 = comHelpers.CreateEditBox(20, 135, 120, 30, "editBox4")
edit4.Text = "Decorated text field"
edit4.TextAlign = comHelpers.TEXTALIGN_RIGHT
edit4.BackgroundColor = comHelpers.CreateColorRGB(255, 240, 240)
edit4.BorderWidth = 2
edit4.BorderStyle = comHelpers.BORDERSTYLE_DASHED
edit4.BorderColor = comHelpers.CreateColorRGB(128, 0, 0)
edit4.FontColor = comHelpers.CreateColorRGB(128, 0, 0)
edit4.Font.Size = 9
page1.Annotations.Add(edit4)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
