'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'



Imports Bytescout.PDFRenderer


Class Program
    Friend Shared Sub Main(args As String())

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
        Dim renderer As New RasterRenderer()
        renderer.RegistrationName = "demo"
        renderer.RegistrationKey = "demo"

        ' Load PDF document.
        renderer.LoadDocumentFromFile("multipage.pdf")

        Dim renderingOptions As RenderingOptions = New RenderingOptions()
        ' Select TIFF compression
        renderingOptions.TIFFCompression = TIFFCompression.LZW

        For i As Integer = 0 To renderer.GetPageCount() - 1
            ' Render document page to TIFF image file.
            renderer.Save("image" & i & ".tif", RasterImageFormat.TIFF, i, 96, renderingOptions)
        Next

        ' Cleanup
        renderer.Dispose()

        ' Open the first output file in default image viewer.
        System.Diagnostics.Process.Start("image0.tif")
    End Sub
End Class
