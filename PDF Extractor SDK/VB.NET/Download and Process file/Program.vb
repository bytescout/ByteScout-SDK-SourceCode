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
Imports Bytescout.PDFExtractor

Class Program
    Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim extractor As New TextExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Input file Url
        Dim inputUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf"

        ' Get Input Stream
        Dim inpStream As Stream = GetStreamFromUrl(inputUrl)

        ' Load sample PDF document from stream
        extractor.LoadDocumentFromStream(inpStream)

        ' Save extracted text to file
        extractor.SaveTextToFile(".\result.txt")

        ' Cleanup
        extractor.Dispose()

        ' Open result file in default associated application (for demo purposes)
        System.Diagnostics.Process.Start(".\result.txt")
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
