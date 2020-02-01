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

        ' Add a data for Surface chart
        Dim count As Integer = 10
        Dim [step] As Double = 2 * Math.PI / (count - 1)
        For i As Integer = 0 To count - 1
            For j As Integer = 0 To count - 1
                sheet(i, j).Value = Math.Sin([step] * Math.Sqrt(i * i + j * j))
            Next
        Next

        ' Add charts to worksheet
        Dim surfaceChart As Chart = sheet.Charts.AddChartAndFitInto(11, 1, 28, 8, ChartType.Surface)
        For i As Integer = 0 To count - 1
            surfaceChart.SeriesCollection.Add(New Series(sheet.Range(0, i, 9, i)))
        Next

        surfaceChart = sheet.Charts.AddChartAndFitInto(11, 10, 28, 17, ChartType.SurfaceWireframe)
        For i As Integer = 0 To count - 1
            surfaceChart.SeriesCollection.Add(New Series(sheet.Range(0, i, 9, i)))
        Next

        surfaceChart = sheet.Charts.AddChartAndFitInto(29, 1, 46, 8, ChartType.SurfaceTopView)
        For i As Integer = 0 To count - 1
            surfaceChart.SeriesCollection.Add(New Series(sheet.Range(0, i, 9, i)))
        Next

        surfaceChart = sheet.Charts.AddChartAndFitInto(29, 10, 46, 17, ChartType.SurfaceTopViewWireframe)
        For i As Integer = 0 To count - 1
            surfaceChart.SeriesCollection.Add(New Series(sheet.Range(0, i, 9, i)))
        Next

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
