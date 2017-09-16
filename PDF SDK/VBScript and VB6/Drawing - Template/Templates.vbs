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


' This example demonstrates how to use templates.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Prepare simple template (for example, a logo) and draw it on every page:

' Create template of specified size
Set template = comHelpers.CreateGraphicsTemplate(250, 50)
' Draw the logo
Set lightBlueBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(200, 200, 255))
template.DrawRectangle_2 (lightBlueBrush), 0, 0, 250, 50
Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMESBOLDITALIC, 24)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
template.DrawString "My Company Logo", (timesFont), (blackBrush), 30, 10

' Add few pages and draw the prepared template on each one
For i = 0 To 2
    Set page = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
    page.Canvas.DrawTemplate (template), 10, 10
    pdfDocument.Pages.Add(page)
Next

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
