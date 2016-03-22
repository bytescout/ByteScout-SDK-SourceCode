'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.IO
Imports System.Windows.Forms
Imports Bytescout.Spreadsheet

Public Partial Class Form1
	Inherits Form
	Private _listview As ListView

	Public Sub New()
		InitializeComponent()

		' Create ListView control
		_listview = New ListView()
		_listview.Dock = DockStyle.Fill
		_listview.View = View.Details
		_listview.FullRowSelect = True

		' Create two columns
		_listview.Columns.Add("Column 1", 100, HorizontalAlignment.Left)
		_listview.Columns.Add("Column 2", 140, HorizontalAlignment.Left)

		' Add created control to the form
		Controls.Add(_listview)

		' Read XLS file

		Dim document As Spreadsheet = Nothing

		Try
			' Get current directory
			Dim currentDirectory As [String] = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)

			' Load XLS document from the current directory
            document = New Spreadsheet()
            document.LoadFromFile(currentDirectory & "\SimpleReport.xls")

			Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

			' Read cell values and put them to the list view
			For row As Integer = 0 To worksheet.UsedRangeRowMax
				Dim item As New ListViewItem(DirectCast(worksheet.Cell(row, 0).Value, String))
				item.SubItems.Add(DirectCast(worksheet.Cell(row, 1).Value, String))
				_listview.Items.Add(item)
			Next
		Catch generatedExceptionName As Exception
			Throw
		Finally
			If document IsNot Nothing Then
				document.Dispose()
			End If
		End Try
	End Sub
End Class
