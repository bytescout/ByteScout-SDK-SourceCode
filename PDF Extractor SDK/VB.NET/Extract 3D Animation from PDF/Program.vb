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

        ' Initialize 3D animations enumeration
        If extractor.GetFirst3D() Then
            Do
                Dim outputFileName As String = "movie" & i & extractor.GetCurrent3DExtension()

                ' Save 3D animation to file
                extractor.SaveCurrent3DToFile(outputFileName)

                i = i + 1

            Loop While extractor.GetNext3D() ' Advance enumeration
        End If

        ' Cleanup
		extractor.Dispose()

    End Sub
End Class
