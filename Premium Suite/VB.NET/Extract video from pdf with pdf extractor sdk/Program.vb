'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
