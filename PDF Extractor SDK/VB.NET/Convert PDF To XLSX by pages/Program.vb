'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
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
