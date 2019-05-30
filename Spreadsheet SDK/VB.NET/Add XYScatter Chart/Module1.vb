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
            sheet.Cell(i, 0).Value = i
            sheet.Cell(i, 1).Value = rnd.NextDouble() * 10
            sheet.Cell(i, 2).Value = rnd.NextDouble() * 10
        Next

        ' Add charts to worksheet
        Dim scatterChart As Chart = sheet.Charts.AddChartAndFitInto(1, 3, 16, 9, ChartType.XYScatter)
        scatterChart.SeriesCollection.Add(New Series(sheet.Range(0, 1, length - 1, 1), sheet.Range(0, 0, length - 1, 0)))
        scatterChart.SeriesCollection.Add(New Series(sheet.Range(0, 2, length - 1, 2)))

        scatterChart = sheet.Charts.AddChartAndFitInto(1, 10, 16, 16, ChartType.XYScatterSmooth)
        scatterChart.SeriesCollection.Add(New Series(sheet.Range(0, 1, length - 1, 1), sheet.Range(0, 0, length - 1, 0)))
        scatterChart.SeriesCollection.Add(New Series(sheet.Range(0, 2, length - 1, 2)))

        scatterChart = sheet.Charts.AddChartAndFitInto(1, 17, 16, 23, ChartType.XYScatterSmoothNoMarkers)
        scatterChart.SeriesCollection.Add(New Series(sheet.Range(0, 1, length - 1, 1), sheet.Range(0, 0, length - 1, 0)))
        scatterChart.SeriesCollection.Add(New Series(sheet.Range(0, 2, length - 1, 2)))

        scatterChart = sheet.Charts.AddChartAndFitInto(17, 10, 32, 16, ChartType.XYScatterLines)
        scatterChart.SeriesCollection.Add(New Series(sheet.Range(0, 1, length - 1, 1), sheet.Range(0, 0, length - 1, 0)))
        scatterChart.SeriesCollection.Add(New Series(sheet.Range(0, 2, length - 1, 2)))

        scatterChart = sheet.Charts.AddChartAndFitInto(17, 17, 32, 23, ChartType.XYScatterLinesNoMarkers)
        scatterChart.SeriesCollection.Add(New Series(sheet.Range(0, 1, length - 1, 1), sheet.Range(0, 0, length - 1, 0)))
        scatterChart.SeriesCollection.Add(New Series(sheet.Range(0, 2, length - 1, 2)))

        ' Save it as XLS
        spreadsheet.SaveAs("Output.xls")

        ' Close the document
        spreadsheet.Close()

        ' Open generated XLS file in default associated application
        Process.Start("Output.xls")

    End Sub

End Module
