'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************


Imports Bytescout.PDFRenderer


Class Program
	Friend Shared Sub Main(args As String())

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
		Dim renderer As New RasterRenderer()
		renderer.RegistrationName = "demo"
		renderer.RegistrationKey = "demo"

		' Load PDF document.
        renderer.LoadDocumentFromFile("multipage.pdf")

        ' define page to start from
        Dim StartPageIndex As Integer = 0
        ' define page to end on
        Dim EndPageIndex As Integer = renderer.GetPageCount() - 1

        ' Render PDF to TIFF image file.
        renderer.RenderPageRangeToMultipageTIFFFile(StartPageIndex, EndPageIndex, TIFFCompression.LZW, "multipage.tiff")

        ' Open the first output file in default image viewer.
        System.Diagnostics.Process.Start("multipage.tiff")
	End Sub
End Class
