'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports Bytescout.Spreadsheet.Charts

Module Module1

    Sub Main()

        ' Create new Spreadsheet object
        Dim spreadsheet As New Spreadsheet()
        spreadsheet.RegistrationName = "demo"
        spreadsheet.RegistrationKey = "demo"

        ' Add new worksheet
        Dim sheet As Worksheet = spreadsheet.Workbook.Worksheets.Add("Sample")

        ' Add few random numbers
        Dim length As Integer = 10
        Dim rnd As New Random()
        For i As Integer = 0 To length - 1
            sheet.Cell(i, 0).Value = rnd.[Next](10)
            sheet.Cell(i, 1).Value = rnd.[Next](10)
        Next

        ' Add charts to worksheet
        Dim doughnutChart As Chart = sheet.Charts.AddChartAndFitInto(12, 1, 35, 9, ChartType.Doughnut)
        doughnutChart.SeriesCollection.Add(New Series(sheet.Range(0, 0, length - 1, 0)))
        doughnutChart.SeriesCollection.Add(New Series(sheet.Range(0, 1, length - 1, 1)))

        doughnutChart = sheet.Charts.AddChartAndFitInto(12, 10, 35, 18, ChartType.DoughnutExploded)
        doughnutChart.SeriesCollection.Add(New Series(sheet.Range(0, 0, length - 1, 0)))
        doughnutChart.SeriesCollection.Add(New Series(sheet.Range(0, 1, length - 1, 1)))

        ' Save it as XLS
        spreadsheet.SaveAs("Output.xls")

        ' Close the document
        spreadsheet.Close()

        ' Cleanup
        spreadsheet.Dispose()

        ' Open generated XLS file in default associated application
        Process.Start("Output.xls")

    End Sub

End Module
