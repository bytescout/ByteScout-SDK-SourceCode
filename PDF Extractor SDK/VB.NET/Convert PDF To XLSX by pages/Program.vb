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

        ' Create Bytescout.PDFExtractor.XLSExtractor instance

        Dim extractor As New XLSExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile("ProductsMonthWise.pdf")

        ' Uncomment this line if you need all pages converted into a single worksheet:
        'extractor.PageToWorksheet = False

        ' Set the output format to XLSX
        extractor.OutputFormat = SpreadseetOutputFormat.XLSX

        ' No of Pages
        Dim pageCount As Int32 = extractor.GetPageCount()

        For i As Int32 = 0 To pageCount - 1
            Dim outputName As String = $"page_{i + 1}.xlsx"

            ' Save page to spreadsheet file
            extractor.SavePageToXLSFile(i, outputName)

            Console.WriteLine("'{0}' Created", outputName)
        Next

        ' Cleanup
        extractor.Dispose()

        Console.ReadLine()

    End Sub

End Class
