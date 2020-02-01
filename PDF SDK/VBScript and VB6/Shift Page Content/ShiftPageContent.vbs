'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' This example demonstrates how to shift page content.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' Load input document
pdfDocument.Load("sample.pdf")

Set page = pdfDocument.Pages.Item(0)

' copy page content as template
Set template = page.SaveAsTemplate()

Set comHelpers = pdfDocument.ComHelpers

' create new page of required size
Set newPage = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)

Set canvas = newPage.Canvas

' draw the stored template on the new page with required offset
canvas.DrawTemplate(template), 50, 50

' replace the old page with the new one
pdfDocument.Pages.Remove(0)
pdfDocument.Pages.Add(newPage)

' Save document to file
pdfDocument.Save("result.pdf")

' Open PDF document in default associated application (for demo puprpose)
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
