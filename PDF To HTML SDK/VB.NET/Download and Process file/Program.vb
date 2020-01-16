'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.IO
Imports Bytescout.PDF2HTML

Class Program
    Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDF2HTML.HTMLExtractor instance
        Dim extractor As New HTMLExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Set plain HTML extraction mode
        extractor.ExtractionMode = HTMLExtractionMode.PlainHTML

        ' Input file Url
        Dim inputUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf"

        ' Get Input Stream
        Dim inpStream As Stream = GetStreamFromUrl(inputUrl)

        ' Load sample PDF document stream
        extractor.LoadDocumentFromStream(inpStream)

        ' Convert 1-st page to HTML and save it to file
        extractor.SaveHtmlPageToFile(0, "output.html")

        ' Cleanup
        extractor.Dispose()

        ' Open output file in default associated application
        System.Diagnostics.Process.Start("output.html")

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
