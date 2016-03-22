'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' This example demonstrates how to use fonts.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Use standard PDF font
Set standardFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 16)
canvas.DrawString "Standard font.", (standardFont), (brush), 20, 20

' Use font installed in system
Set systemFont = comHelpers.CreateSystemFont("Arial", 16)
canvas.DrawString "Windows font.", (systemFont), (brush), 20, 50

' Use font loaded from file
Set fontFromFile = comHelpers.LoadFontFromFile("VeraBI.ttf", 16)
canvas.DrawString "Font loaded from file.", (fontFromFile), (brush), 20, 80

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
