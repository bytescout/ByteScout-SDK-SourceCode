'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'



Imports System.IO
Imports Bytescout.PDFRenderer


Class Program
    Friend Shared Sub Main(args As String())

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
        Dim renderer As New RasterRenderer()
        renderer.RegistrationName = "demo"
        renderer.RegistrationKey = "demo"

        ' Input file Url
        Dim inputUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf"

        ' Get Input Stream
        Dim inpStream As Stream = GetStreamFromUrl(inputUrl)

        ' Load PDF document from stream.
        renderer.LoadDocumentFromStream(inpStream)

        For i As Integer = 0 To renderer.GetPageCount() - 1
            ' Render document page to PNG image file.
            renderer.Save("image" & i & ".jpg", RasterImageFormat.JPEG, i, 96)
        Next

        ' Cleanup
        renderer.Dispose()

        ' Open the first output file in default image viewer.
        System.Diagnostics.Process.Start("image0.jpg")
    End Sub

    ''' <summary>
    ''' Get stream from Url
    ''' </summary>
    Private Shared Function GetStreamFromUrl(ByVal url As String) As Stream

        Dim oData As Byte() = Nothing

        Using wc As New System.Net.WebClient()
            oData = wc.DownloadData(url)
        End Using

        Return New MemoryStream(oData)

    End Function


End Class
