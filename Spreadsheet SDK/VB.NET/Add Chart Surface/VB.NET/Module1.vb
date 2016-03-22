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

				' add a data for Surface chart
				Dim count As Integer = 10
				Dim [step] As Double = 2 * Math.PI / (count - 1)
				For i As Integer = 0 To count - 1
					For j As Integer = 0 To count - 1
						sheet(i, j).Value = Math.Sin([step] * Math.Sqrt(i * i + j * j))
					Next
				Next

				' add charts to worksheet
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
