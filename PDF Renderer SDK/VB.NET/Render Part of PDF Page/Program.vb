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
        
        ' Set high quality resolution 600 dpi (600 dots per inch)
        Dim renderingResolution As Single = 600
        
        ' Load PDF document.
        renderer.LoadDocumentFromFile("sample_table.pdf")

        ' Set extraction area
        renderer.SetExtractionArea(205.5f, 108.75f, 331.5f, 121.5f)

        ' Render part of document to PNG image file.
        renderer.Save($"result_{renderingResolution}.png", RasterImageFormat.PNG, 0, renderingResolution)

        ' Cleanup
        renderer.Dispose()

        ' Open the first output file in default image viewer.
        System.Diagnostics.Process.Start($"result_{renderingResolution}.png")
    End Sub
End Class
