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
Imports System.Drawing.Imaging

Class Program
	Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.ImageExtractor instance
        Dim extractor As New ImageExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		' Load sample PDF document
        extractor.LoadDocumentFromFile(".\sample1.pdf")

        ' Get count of pages
		Dim pageCount As Integer = extractor.GetPageCount()

        ' Extract images from each page
        For i As Integer = 0 To pageCount - 1

            Dim j As Integer = 0

            ' Initialize page images enumeration
            If extractor.GetFirstPageImage(i) Then
                Do
                    Dim outputFileName As String = "page" & i & "image" & j & ".png"

                    ' Save image to file
                    extractor.SaveCurrentImageToFile(outputFileName, ImageFormat.Png)

                    j = j + 1

                Loop While extractor.GetNextImage() ' Advance image enumeration
            End If

        Next

        ' Cleanup
		extractor.Dispose()

		' Open result file in default associated application (for demo purposes)
        System.Diagnostics.Process.Start("page0image0.png")
        
	End Sub
End Class
