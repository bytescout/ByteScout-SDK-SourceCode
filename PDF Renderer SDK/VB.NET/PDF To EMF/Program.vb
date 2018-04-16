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

        ' Create an instance of Bytescout.PDFRenderer.VectorRenderer object and register it.
        Dim renderer As New VectorRenderer()
		renderer.RegistrationName = "demo"
		renderer.RegistrationKey = "demo"

		' Load PDF document.
        renderer.LoadDocumentFromFile("vector_drawing.pdf")

		For i As Integer = 0 To renderer.GetPageCount() - 1
            ' Render document page to EMF image file
            renderer.Save("image" & i & ".emf", i, 300)
		Next

		' Open the first output file in default image viewer.
        System.Diagnostics.Process.Start("image0.emf")
	End Sub
End Class
