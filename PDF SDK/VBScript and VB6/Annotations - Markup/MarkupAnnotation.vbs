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


' This example demonstrates how to add markup annotations.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Draw sample markup annotations

Set squareAnnotation = comHelpers.CreateSquareAnnotation(20, 20, 80, 80)
squareAnnotation.BackgroundColor = comHelpers.CreateColorRGB(255, 240, 240)
squareAnnotation.BorderStyle.Style = comHelpers.BORDERSTYLE_DASHED
squareAnnotation.BorderStyle.DashPattern = comHelpers.CreateDashPattern(Array(3.0, 1.0, 3.0), 0)
page1.Annotations.Add(squareAnnotation)

Set circleAnnotation = comHelpers.CreateCircleAnnotation(120, 20, 80, 80)
circleAnnotation.BackgroundColor = comHelpers.CreateColorRGB(240, 250, 240)
circleAnnotation.Color = comHelpers.CreateColorRGB(128, 0, 128)
circleAnnotation.BorderEffect.Effect = comHelpers.BORDEREFFECT_CLOUDY
circleAnnotation.BorderEffect.Intensity = 2
page1.Annotations.Add(circleAnnotation)

Set lineAnnotation = comHelpers.CreateLineAnnotation(20, 180, 100, 120)
lineAnnotation.Color = comHelpers.CreateColorRGB(255, 0, 0)
lineAnnotation.StartLineStyle = comHelpers.LINEENDINGSTYLE_BUTT
lineAnnotation.EndLineStyle = comHelpers.LINEENDINGSTYLE_OPENARROW
page1.Annotations.Add(lineAnnotation)

Set pointsArray = comHelpers.CreatePointsArray(Array(Array(120, 120), Array(130, 130), Array(140, 120), Array(150, 130), Array(160, 120), Array(170, 130)))
Set polylineAnnotation = comHelpers.CreatePolylineAnnotation((pointsArray))
polylineAnnotation.BorderStyle.Width = 2
page1.Annotations.Add(polylineAnnotation)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
