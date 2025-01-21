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
Imports System.IO

Class Program

	Friend Shared Sub Main(args As String())

        ' When processing huge PDF documents you may run into OutOfMemoryException.
        ' This example demonstrates a way to spare the memory by disabling page data caching.

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Using extractor As New TextExtractor("demo", "demo")

            Try
                ' Load sample PDF document
                extractor.LoadDocumentFromFile("sample2.pdf")

                ' Disable page data caching, so processed pages wiil be disposed automatically
                extractor.PageDataCaching = PageDataCaching.None

                ' Save extracted text to file
                extractor.SaveTextToFile("output.txt")

            Catch exception As PDFExtractorException
                Console.Write(exception.ToString())
            End Try

        End Using

        ' Open result file in default associated application (for demo purposes)
        System.Diagnostics.Process.Start("output.txt")

    End Sub

End Class
