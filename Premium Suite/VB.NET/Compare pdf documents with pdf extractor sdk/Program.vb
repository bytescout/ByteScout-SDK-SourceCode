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
        Friend Shared Sub Main(args As String())

        ' Load first document
        Dim document1 As TextExtractor = New TextExtractor()
        document1.RegistrationName = "demo"
        document1.RegistrationKey = "demo"
        document1.LoadDocumentFromFile(".\comparison1.pdf")

        ' Load second  document
        Dim document2 As TextExtractor = New TextExtractor()
        document2.RegistrationName = "demo"
        document2.RegistrationKey = "demo"
        document2.LoadDocumentFromFile(".\comparison2.pdf")

        ' Compare documents
        Dim comparer As TextComparer = New TextComparer()
        comparer.RegistrationName = "demo"
        comparer.RegistrationKey = "demo"
        comparer.Compare(document1, document2)

        ' Generate report
        comparer.GenerateHtmlReport(".\report.html")

        ' Cleanup
        document1.Dispose()
        document2.Dispose()

        ' Open the report in default browser
        System.Diagnostics.Process.Start(".\report.html")

        End Sub
End Class
