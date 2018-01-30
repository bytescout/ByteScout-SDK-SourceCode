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


' This example demonstrates how to change the word spacing.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add pages
pdfDocument.Pages.Add(comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4))
pdfDocument.Pages.Add(comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4))
pdfDocument.Pages.Add(comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4))

Set font1 = comHelpers.CreateSystemFont("Times New Roman", 16)
Set font2 = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_HELVETICABOLD, 24)

Set semitransparentRedBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
semitransparentRedBrush.Opacity = 50 ' make the brush semitransparent
Set greenBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 128, 0))
Set semitransparentBlueBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255))
semitransparentBlueBrush.Opacity = 50 ' make the brush semitransparent
Set redPen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(255, 0, 0), 1)

' Add tiling watermark
Set watermark1 = comHelpers.CreateTextWatermark("Tiling Watermark")
watermark1.WatermarkLocation = comHelpers.TEXTWATERMARKLOCATION_TILED
watermark1.Angle = 30
watermark1.Brush = semitransparentBlueBrush
pdfDocument.Watermarks.Add(watermark1)

' Add autosized watermark to every page of the document
Set watermark2 = comHelpers.CreateTextWatermark("Center Watermark")
watermark2.WatermarkLocation = comHelpers.TEXTWATERMARKLOCATION_DIAGONALFROMBOTTOMLEFTTOTOPRIGHT
watermark2.Font = font1
watermark2.Brush = semitransparentRedBrush
watermark2.Pen = redPen
pdfDocument.Watermarks.Add(watermark2)

' Add watermark of custom size and location to the first page only
Set watermark3 = comHelpers.CreateTextWatermark("Simple Watermark")
watermark3.Font = font2
watermark3.Brush = greenBrush
watermark3.Left = 350
watermark3.Top = 800
pdfDocument.Pages.Item(0).Watermarks.Add(watermark3)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
