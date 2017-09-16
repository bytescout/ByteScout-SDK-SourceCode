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


' This example demonstrates how to add images of various formats. 

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Add JPEG image and draw unscaled
Set image1 = comHelpers.CreateImage("Image1.jpg")
canvas.DrawImage (image1), 20, 20

' Add PNG image and draw reduced twice
Set image2 = comHelpers.CreateImage("Image2.png")
canvas.DrawImage_2 (image2), 20, 520, image2.Width / 2, image2.Height / 2

' Add TIFF image and draw scaled disproportionately
Set image3 = comHelpers.CreateImage("Image3.tif")
canvas.DrawImage_2 (image3), 270, 520, image3.Width / 2, image3.Height / 4

' Add GIF image and draw rotated 90 degrees and scaled
Set image4 = comHelpers.CreateImage("Image4.gif")
canvas.TranslateTransform 390, 650
canvas.RotateTransform 90
canvas.DrawImage_2 (image4), 0, 0, image4.Width / 4, image4.Height / 4

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
