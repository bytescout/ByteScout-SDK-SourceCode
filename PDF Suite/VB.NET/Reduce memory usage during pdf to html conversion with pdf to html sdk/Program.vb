'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDF2HTML

Class Program
    Friend Shared Sub Main(args As String())

        ' When processing huge PDF documents you may run into OutOfMemoryException.
        ' This example demonstrates a way to spare the memory by disabling page data caching.

        ' Create Bytescout.PDF2HTML.HTMLExtractor instance
        Using extractor As New HTMLExtractor("demo", "demo")

            Try
                ' Load sample PDF document
                extractor.LoadDocumentFromFile("sample2.pdf")

                ' Disable page data caching, so processed pages will be disposed automatically
                extractor.PageDataCaching = PageDataCaching.None

                ' Save result to file
                extractor.SaveHtmlToFile("output.html")

            Catch exception As PDF2HTMLException
                Console.Write(exception.ToString())
            End Try

        End Using

        ' Open the output file in default associated application
        System.Diagnostics.Process.Start("output.txt")

    End Sub
End Class
