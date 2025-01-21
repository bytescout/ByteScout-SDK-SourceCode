'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Diagnostics
Imports Bytescout.PDFExtractor

Class Program
    Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.CSVExtractor instance
        Dim extractor As New CSVExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\SampleGroupDisabilityForm.pdf")

        ' Set extraction area
        extractor.SetExtractionArea(New Drawing.RectangleF(27.0F, 324.8F, 554.3F, 358.5F))

        ' Check whether rows can be grouped
        extractor.LineGroupingMode = LineGroupingMode.GroupByRows

        ' Extract results
        Dim outputFile As String = "result.csv"
        extractor.SaveCSVToFile(outputFile)

        ' Cleanup
        extractor.Dispose()

        ' Open with default associated program
        Process.Start(outputFile)

    End Sub
End Class
