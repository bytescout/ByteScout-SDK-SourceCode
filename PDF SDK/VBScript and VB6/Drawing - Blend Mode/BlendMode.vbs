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


' This example demonstrates how to use blend modes - a way how 
' intersecting semi-transparent objects will blend on page canvas.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Create transparent brushes
Set brushRed = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
brushRed.Opacity = 50
Set brushGreen = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 255, 0))
brushGreen.Opacity = 50
Set brushBlue = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255))
brushBlue.Opacity = 50

' Normal blending
canvas.BlendMode = comHelpers.BLENDMODE_NORMAL
canvas.DrawCircle_2 (brushRed), 100, 100, 50
canvas.DrawCircle_2 (brushGreen), 100, 150, 50
canvas.DrawCircle_2 (brushBlue), 150, 100, 50

' Darken blending
canvas.BlendMode = comHelpers.BLENDMODE_DARKEN
canvas.DrawCircle_2 (brushRed), 300, 100, 50
canvas.DrawCircle_2 (brushGreen), 300, 150, 50
canvas.DrawCircle_2 (brushBlue), 350, 100, 50

' Lighten blending
canvas.BlendMode = comHelpers.BLENDMODE_LIGHTEN
canvas.DrawCircle_2 (brushRed), 100, 300, 50
canvas.DrawCircle_2 (brushGreen), 100, 350, 50
canvas.DrawCircle_2 (brushBlue), 150, 300, 50

' Color burn blending
canvas.BlendMode = comHelpers.BLENDMODE_COLORBURN
canvas.DrawCircle_2 (brushRed), 300, 300, 50
canvas.DrawCircle_2 (brushGreen), 300, 350, 50
canvas.DrawCircle_2 (brushBlue), 350, 300, 50

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
