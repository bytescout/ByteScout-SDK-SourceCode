'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.IO
Imports System.Diagnostics
Imports Bytescout.Spreadsheet
Imports Bytescout.Spreadsheet.Structures

Class Program
	Friend Shared Sub Main(args As String())
		' Create new Spreadsheet
		Dim document As New Spreadsheet()

		' Add new worksheet
		Dim worksheet As Worksheet = document.Workbook.Worksheets.Add("HelloWorld")

		' Set cell value
		worksheet.Cell(0, 0).Value = "Hello, World!"

		' Add horizontal page break
		worksheet.HPageBreaks.Add(New CellsRange("A10"))

		' Add vertical page break
		worksheet.VPageBreaks.Add(New CellsRange("F1"))

		' Save document
		document.SaveAs("Output.xls")

		' Close Spreadsheet
		document.Close()

		' Open generated XLS document in default associated application
		Process.Start("Output.xls")
	End Sub
End Class
