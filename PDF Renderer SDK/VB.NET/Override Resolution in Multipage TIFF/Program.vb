'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
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

        ' define page to start from
        Dim startPage As Integer = 0
        ' define page to end on
        Dim endPage As Integer = renderer.GetPageCount() - 1

        ' Save PDF document to black-and-white multi-page TIFF
        Dim renderingOptions As New RenderingOptions()
        renderingOptions.TIFFCompression = TIFFCompression.CCITT4
        renderingOptions.ResolutionOverride = 300

        ' Generate 800x600 px multipage TIFF
        renderer.SaveMultipageTiff("multipage.tiff", startPage, endPage, 600, 800, renderingOptions)

        ' Cleanup
        renderer.Dispose()

        ' Open the first output file in default image viewer.
        System.Diagnostics.Process.Start("multipage.tiff")
    End Sub
End Class
