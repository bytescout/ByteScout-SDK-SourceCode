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

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\sample1.pdf")

        ' Get page count
        Dim pageCount As Integer = extractor.GetPageCount()

        For i As Integer = 0 To pageCount - 1

            ' Create new stream. You can use MemoryStream or any other System.IO.Stream inheritor.
            Dim stream As FileStream = New FileStream(".\page" + i.ToString() + ".txt", FileMode.Create)

            ' Save text from page to the file stream
            extractor.SavePageTextToStream(i, stream)

            ' Close stream
            stream.Dispose()

        Next

        ' Cleanup
		extractor.Dispose()

        ' Open result file in default associated application (for demo purposes)
        System.Diagnostics.Process.Start(".\page1.txt")

    End Sub

End Class
