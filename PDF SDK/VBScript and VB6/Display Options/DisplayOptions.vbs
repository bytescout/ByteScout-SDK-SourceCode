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


' This example demonstrates how to set display options for a viewer application.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Set page mode (which panels should be shown at viewing application start)
pdfDocument.PageMode = comHelpers.PAGEMODE_THUMBNAIL ' show thumbnails panel

' Show/hide various interface elements
pdfDocument.ViewerPreferences.CenterWindow = True
pdfDocument.ViewerPreferences.FitWindow = True
pdfDocument.ViewerPreferences.HideMenubar = True
pdfDocument.ViewerPreferences.HideToolbar = True
pdfDocument.ViewerPreferences.HideWindowUI = False

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
