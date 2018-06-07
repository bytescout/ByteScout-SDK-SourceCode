'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

Class Program
    Friend Shared Sub Main(ByVal args As String())

        ' Create Bytescout.PDFExtractor.MultimediaExtractor instance
        Dim extractor As New MultimediaExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

        ' Load sample PDF document
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
