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

        ' Create Bytescout.PDFExtractor.Remover2 instance
        Dim remover As New Remover2("demo", "demo")

        ' Mask removed text, which ultimately black out region
        remover.MaskRemovedText = True

        ' Load sample PDF document
        remover.LoadDocumentFromFile("samplePDF_EmailSSN.pdf")

        ' Prepare TextExtractor
        Using textExtractor As New TextExtractor("demo", "demo")

            ' Load document into TextExtractor
            textExtractor.LoadDocumentFromFile("samplePDF_EmailSSN.pdf")

            ' Enable RegexSearch
            textExtractor.RegexSearch = True

            ' Set word matching options
            textExtractor.WordMatchingMode = WordMatchingMode.None

            ' Search SSN in format 202-55-0130
            Dim regexPatternSSN As String = "[0-9]{3}-[0-9]{2}-[0-9]{4}"

            ' Search email Addresses
            Dim regexPatternEmail As String = "\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}\b"

            ' Search results for SSN
            Dim searchResultsSSN() As ISearchResult = textExtractor.FindAll(0, regexPatternSSN, caseSensitive:=False)

            ' Search results for Email
            Dim searchResultEmail() As ISearchResult = textExtractor.FindAll(0, regexPatternEmail, caseSensitive:=False)

            ' Remove SSN result text objects find by SearchResults.
            remover.AddTextToRemove(searchResultsSSN)

            ' Remove Email result text objects find by SearchResults.
            remover.AddTextToRemove(searchResultEmail)

            ' Perform removal of specified objects
            remover.PerformRemoval("result1.pdf")
        
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
