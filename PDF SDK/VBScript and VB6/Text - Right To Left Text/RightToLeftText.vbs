'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' This example demonstrates how to draw right-to-left text.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set font = comHelpers.CreateSystemFont("Arial", 16)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Set right to left text direction
Set stringFormat = comHelpers.CreateStringFormat()
stringFormat.DirectionRightToLeft = True

page1.Canvas.DrawString_4 "واحد اثنين ثلاثة", (font), (brush), page1.Width - 20, 30, (stringFormat)
page1.Canvas.DrawString_4 "אחת, שתיים, שלוש", (font), (brush), page1.Width - 20, 50, (stringFormat)
page1.Canvas.DrawString_4 "یک دو سه", (font), (brush), page1.Width - 20, 70, (stringFormat)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
