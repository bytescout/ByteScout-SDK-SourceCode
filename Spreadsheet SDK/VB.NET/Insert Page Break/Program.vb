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
