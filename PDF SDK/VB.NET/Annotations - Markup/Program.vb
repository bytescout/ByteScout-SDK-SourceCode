'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports System.Drawing
Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to add markup annotations.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        ' Add page
        Dim page = New Page(PaperFormat.A4)
		pdfDocument.Pages.Add(page)

		' Draw sample markup annotations

		Dim squareAnnotation = New SquareAnnotation(20, 20, 80, 80)
		squareAnnotation.BackgroundColor = New ColorRGB(255, 240, 240)
		squareAnnotation.BorderStyle.Style = BorderStyle.Dashed
		squareAnnotation.BorderStyle.DashPattern = New DashPattern(New Single() {3, 1, 3})
		page.Annotations.Add(squareAnnotation)

		Dim circleAnnotation = New CircleAnnotation(120, 20, 80, 80)
		circleAnnotation.BackgroundColor = New ColorRGB(240, 250, 240)
		circleAnnotation.Color = New ColorRGB(128, 0, 128)
		circleAnnotation.BorderEffect.Effect = BorderEffect.Cloudy
		circleAnnotation.BorderEffect.Intensity = 2
		page.Annotations.Add(circleAnnotation)

		Dim lineAnnotation = New LineAnnotation(20, 180, 100, 120)
		lineAnnotation.Color = New ColorRGB(255, 0, 0)
		lineAnnotation.StartLineStyle = LineEndingStyle.Butt
		lineAnnotation.EndLineStyle = LineEndingStyle.OpenArrow
		page.Annotations.Add(lineAnnotation)

		Dim pp = {New PointF(120, 120), New PointF(130, 130), New PointF(140, 120), New PointF(150, 130), New PointF(160, 120), New PointF(170, 130)}
		Dim points = New PointsArray(pp)
		Dim polylineAnnotation = New PolylineAnnotation(points)
		polylineAnnotation.BorderStyle.Width = 2
		page.Annotations.Add(polylineAnnotation)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
