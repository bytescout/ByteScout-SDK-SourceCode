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
