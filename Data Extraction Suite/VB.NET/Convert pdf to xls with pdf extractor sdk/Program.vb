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
Imports System.Diagnostics

Class Program

    Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.XLSExtractor instance

        Dim extractor As New XLSExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        File.Delete("output.xls")

        ' Load sample PDF document
        extractor.LoadDocumentFromFile("sample3.pdf")

        ' Uncomment this line if you need all pages converted into a single worksheet:
        'extractor.PageToWorksheet = False

        ' Set the output format to XLS
        extractor.OutputFormat = SpreadseetOutputFormat.XLS

        ' Save the spreadsheet to file
        extractor.SaveToXLSFile("output.xls")

        ' Cleanup
        extractor.Dispose()

        ' Open result file in default associated application (for demo purposes)
        Process.Start("output.xls")

    End Sub

End Class
