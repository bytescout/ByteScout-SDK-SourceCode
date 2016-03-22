'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.Spreadsheet
Imports Bytescout.Spreadsheet.Charts
Imports System.IO


Module Module1

    Sub Main()


			Try
				' create new Spreadsheet object
				Dim spreadsheet As New Spreadsheet()

				' add new worksheet
				Dim sheet As Worksheet = spreadsheet.Workbook.Worksheets.Add("Sample")

				' add a random numbers
				Dim length As Integer = 10
				Dim rnd As New Random()
				For i As Integer = 0 To length - 1
					sheet.Cell(i, 0).Value = rnd.[Next](10)
					sheet.Cell(i, 1).Value = rnd.[Next](10)
				Next

				' add charts to worksheet
				Dim doughnutChart As Chart = sheet.Charts.AddChartAndFitInto(12, 1, 35, 9, ChartType.Doughnut)
				doughnutChart.SeriesCollection.Add(New Series(sheet.Range(0, 0, length - 1, 0)))
				doughnutChart.SeriesCollection.Add(New Series(sheet.Range(0, 1, length - 1, 1)))

				doughnutChart = sheet.Charts.AddChartAndFitInto(12, 10, 35, 18, ChartType.DoughnutExploded)
				doughnutChart.SeriesCollection.Add(New Series(sheet.Range(0, 0, length - 1, 0)))
				doughnutChart.SeriesCollection.Add(New Series(sheet.Range(0, 1, length - 1, 1)))

				If File.Exists("Output.xls") Then
					File.Delete("Output.xls")
				End If

				' Save it as XLS
				spreadsheet.SaveAs("Output.xls")

				' close the document
				spreadsheet.Close()

				' open output XLS


				Process.Start("Output.xls")
			Catch e As Exception
				Console.WriteLine("CAN NOT EXECUTE: " & e.ToString())
				Console.WriteLine("" & Chr(10) & "Press any key to exit")
				Console.ReadKey()
			End Try


    End Sub

End Module
