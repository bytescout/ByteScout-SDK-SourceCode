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



Imports Bytescout.PDFRenderer


Class Program
	Friend Shared Sub Main(args As String())

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
		Dim renderer As New RasterRenderer()
		renderer.RegistrationName = "demo"
		renderer.RegistrationKey = "demo"

		' Load PDF document.
		renderer.LoadDocumentFromFile("multipage.pdf")

		For i As Integer = 0 To renderer.GetPageCount() - 1
            ' Render document page to PNG image file.
            renderer.Save("image" & i & ".png", RasterImageFormat.PNG, i, 96)
		Next

		' Open the first output file in default image viewer.
		System.Diagnostics.Process.Start("image0.png")
	End Sub
End Class
