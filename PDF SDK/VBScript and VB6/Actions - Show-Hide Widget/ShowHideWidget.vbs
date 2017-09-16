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


' This example demonstrates how to show/hide a widget in document.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Create widget that will be shown/hidden
Set editBox1 = comHelpers.CreateEditBox(20, 20, 100, 25, "editBox1")
editBox1.Text = "editBox1"
page1.Annotations.Add(editBox1)

' Create button that will show the widget
Set buttonShow = comHelpers.CreatePushButton(20, 80, 50, 25, "buttonShow")
buttonShow.Caption = "Show"
page1.Annotations.Add(buttonShow)
' Add Show action
Set showAction = comHelpers.CreateHideAction(False)
showAction.Fields.Add(editBox1)
buttonShow.OnActivated = showAction

' Create button that will hide the widget
Set buttonHide = comHelpers.CreatePushButton(100, 80, 50, 25, "buttonHide")
buttonHide.Caption = "Hide"
page1.Annotations.Add(buttonHide)
' Add Hide action
Set hideAction = comHelpers.CreateHideAction(True)
hideAction.Fields.Add(editBox1)
buttonHide.OnActivated = hideAction

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
