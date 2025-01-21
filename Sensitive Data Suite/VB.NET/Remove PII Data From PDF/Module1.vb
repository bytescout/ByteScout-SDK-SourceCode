'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing
Imports Bytescout.PDFExtractor

Class Program

    Shared Sub Main(ByVal args As String())

        ' Create Bytescout.PDFExtractor.Remover instance
        Dim remover As New Remover("demo", "demo")

        ' Load sample PDF document
        remover.LoadDocumentFromFile("samplePDF_SSNNo.pdf")

        ' Prepare TextExtractor
        Using textExtractor As New TextExtractor("demo", "demo")

            ' Load document into TextExtractor
            textExtractor.LoadDocumentFromFile("samplePDF_SSNNo.pdf")

            ' Search SSN in format 202-55-0130
            'See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx
            Dim regexPattern As String = "[0-9]{3}-[0-9]{2}-[0-9]{4}"

            ' Enable RegexSearch
            textExtractor.RegexSearch = True

            ' Set word matching options
            textExtractor.WordMatchingMode = WordMatchingMode.None

            Dim searchResults() As ISearchResult = textExtractor.FindAll(0, regexPattern, caseSensitive:=False)

            ' Remove text objects find by SearchResults.
            ' NOTE: The removed text might be larger than the specified rectangle. Currently the Remover Is unable 
            ' to split PDF text objects.
            remover.RemoveText(searchResults, "result1.pdf")

        End Using

        ' Clean up.
        remover.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue and open result PDF files in default PDF viewer...")
        Console.ReadKey()

        Dim processStartInfo As New ProcessStartInfo("result1.pdf")
        processStartInfo.UseShellExecute = True
        Process.Start(processStartInfo)

    End Sub

End Class
