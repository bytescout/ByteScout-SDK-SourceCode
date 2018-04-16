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
Imports Bytescout.PDFRenderer

Module Module1

    Sub Main()

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
        Dim renderer As New RasterRenderer()
        renderer.RegistrationName = "demo"
        renderer.RegistrationKey = "demo"

        ' Load PDF document
        renderer.LoadDocumentFromFile("multipage.pdf")

		' Get size of the page in Points (standard PDF document units; 1 Point = 1/72")
		Dim rectangle As RectangleF = renderer.GetPageRectangle(0)

		Dim width, height As Integer

        If rectangle.Width < rectangle.Height Then ' portrait page orientation

			width = -1 ' width will be calculated from height keeping the aspect ratio
			height = 100

        Else ' landscape page orientation

			width = 100
			height = -1	' height will be calculated from width keeping the aspect ratio

        End If

        ' Render first page of the document to JPEG image file
		renderer.Save("thumbnail.jpg", RasterImageFormat.JPEG, 0, width, height)

        ' Open the output image file in default image viewer
        System.Diagnostics.Process.Start("thumbnail.jpg")

    End Sub

End Module
