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


' This example demonstrates how to add a text annotation.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add collapsed annotation (shown as a tooltip when mouse is over the icon)
Set collapsedAnnotation = comHelpers.CreateTextAnnotation(20, 20)
collapsedAnnotation.Color = comHelpers.CreateColorRGB(255, 255, 0)
collapsedAnnotation.Icon = comHelpers.TEXTANNOTATIONICON_COMMENT
collapsedAnnotation.Author = "Mr. Important"
collapsedAnnotation.Contents = "The quick brown fox jumps over the lazy dog."
page1.Annotations.Add(collapsedAnnotation)

' Add expanded annotation
Set expandedAnnotation = comHelpers.CreateTextAnnotation(20, 50)
expandedAnnotation.Color = comHelpers.CreateColorRGB(255, 0, 0)
expandedAnnotation.Icon = comHelpers.TEXTANNOTATIONICON_NOTE
expandedAnnotation.Open = True
expandedAnnotation.Author = "John Doe"
expandedAnnotation.Contents = "The quick brown fox jumps over the lazy dog."
page1.Annotations.Add(expandedAnnotation)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
