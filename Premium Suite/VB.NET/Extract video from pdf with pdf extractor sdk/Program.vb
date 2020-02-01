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


Imports Bytescout.PDFExtractor

Class Program
    Friend Shared Sub Main(ByVal args As String())

        ' Create Bytescout.PDFExtractor.MultimediaExtractor instance
        Dim extractor As New MultimediaExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

        ' Load PDF document
        ' (!) We do not provide the sample document, please load your own.
        extractor.LoadDocumentFromFile("sample.pdf")

        Dim i As Integer = 0

        ' Initialize movies enumeration
        If extractor.GetFirstVideo() Then
            Do
                Dim outputFileName As String = "movie" & i & extractor.GetCurrentVideoExtension()

                ' Save movie to file
                extractor.SaveCurrentVideoToFile(outputFileName)

                i = i + 1

            Loop While extractor.GetNextVideo() ' Advance movies enumeration
        End If

        ' Cleanup
		extractor.Dispose()

    End Sub
End Class
