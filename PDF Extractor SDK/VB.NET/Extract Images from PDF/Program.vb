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


Imports Bytescout.PDFExtractor
Imports System.Drawing.Imaging

Class Program
    Friend Shared Sub Main(ByVal args As String())

        ' Create Bytescout.PDFExtractor.ImageExtractor instance
        Dim extractor As New ImageExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\sample1.pdf")

        Dim i As Integer = 0

        ' Initialize image enumeration
        If extractor.GetFirstImage() Then
            Do
                Dim outputFileName As String = "image" & i & ".png"

                ' Save image to file
                extractor.SaveCurrentImageToFile(outputFileName, ImageFormat.Png)

                i = i + 1

            Loop While extractor.GetNextImage() ' Advance image enumeration
        End If

        ' Cleanup
		extractor.Dispose()

        ' Open result file in default associated application (for demo purposes)
        System.Diagnostics.Process.Start("image0.png")

    End Sub
End Class
