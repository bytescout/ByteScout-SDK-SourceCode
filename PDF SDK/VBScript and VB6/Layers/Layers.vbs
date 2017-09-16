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


' This example demonstrates how to add layers with optional content.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Add main layer
Set allContents = comHelpers.CreateLayer("Main Layer")
canvas.BeginMarkedContent(allContents)

' Add sub-layer
Set layer1 = comHelpers.CreateLayer("Square")
canvas.BeginMarkedContent(layer1)
canvas.DrawRectangle_2 comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 255, 0)), 20, 20, 100, 100
canvas.EndMarkedContent()

' Add second sub-layer
Set layer2 = comHelpers.CreateLayer("Circle")
canvas.BeginMarkedContent(layer2)
canvas.DrawCircle_2 comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0)), 70, 180, 50
canvas.EndMarkedContent()

' Add third sub-layer
Set layer3 = comHelpers.CreateLayer("Triangle")
canvas.BeginMarkedContent(layer3)
Set pointsArray = comHelpers.CreatePointsArray(Array(Array(20, 340), Array(70, 240), Array(120, 340)))
canvas.DrawPolygon_2 comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255)), (pointsArray)
canvas.EndMarkedContent()

canvas.EndMarkedContent()

pdfDocument.OptionalContents.Layers.Add(layer1)
pdfDocument.OptionalContents.Layers.Add(layer2)
pdfDocument.OptionalContents.Layers.Add(layer3)
pdfDocument.OptionalContents.Layers.Add(allContents)

' Configure layers

' Group sub-layers
Set group = comHelpers.CreateOptionalContentGroup()
group.Add(comHelpers.CreateOptionalContentGroupLayer((layer1)))
group.Add(comHelpers.CreateOptionalContentGroupLayer((layer2)))
group.Add(comHelpers.CreateOptionalContentGroupLayer((layer3)))

' Order sub-layers
pdfDocument.OptionalContents.Configuration.Order.Add(comHelpers.CreateOptionalContentGroupLayer((allContents)))
pdfDocument.OptionalContents.Configuration.Order.Add(group)

' Make the third layer invisible by default (for example)
pdfDocument.OptionalContents.Configuration.OFF.Add(layer3)

' Force the PDF viewer to show the layers panel initially
pdfDocument.PageMode = comHelpers.PAGEMODE_OPTIONALCONTENT

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
