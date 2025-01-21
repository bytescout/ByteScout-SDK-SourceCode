'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports Bytescout.Spreadsheet

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()

		dataGrid1.DataSource = GetDemoDataTable()
	End Sub

	Private Sub btnImport_Click(sender As Object, e As EventArgs)
		Cursor = Cursors.WaitCursor

		Try
			Const  fileName As String = "CSharpImportFromDataTable.xls"

			' retrieve DataTable from DataGrid
			Dim dataTable As DataTable = DirectCast(dataGrid1.DataSource, DataTable)

			' Create spreadsheet
			Dim spreadsheet As New Spreadsheet()

			' Import data from DataTable into spreadheet
			spreadsheet.ImportFromDataTable(dataTable)

			' Insert row with column captions
			Dim worksheet As Worksheet = spreadsheet.Worksheets(0)
			worksheet.Rows.Insert(0)
			For colIndex As Integer = 0 To dataTable.Columns.Count - 1
				worksheet.Cell(0, colIndex).Value = dataTable.Columns(colIndex).Caption
			Next

			' Save the spreadsheet
			If File.Exists(fileName) Then
				File.Delete(fileName)
			End If
			spreadsheet.SaveAs(fileName)

			' Close spreadsheet
			spreadsheet.Close()

			' Open the spreadsheet
			Process.Start(fileName)
		Finally
			Cursor = Cursors.[Default]
		End Try
	End Sub

	Private Sub btnExport_Click(sender As Object, e As EventArgs)
		If openFileDialog1.ShowDialog() = DialogResult.OK Then
			Cursor = Cursors.WaitCursor

			Try
				' Create spreadsheet
				Dim spreadsheet As New Spreadsheet()

				' Load spreadsheet from file
				spreadsheet.LoadFromFile(openFileDialog1.FileName)

				' Export to DataGrid
				Dim dataTable As DataTable = spreadsheet.ExportToDataTable()
				dataGrid1.DataSource = dataTable
			Finally
				Cursor = Cursors.[Default]
			End Try
		End If
	End Sub

	''' <summary>
	''' Fills a data table of the periodic table of elements.
	''' </summary>
	Private Function GetDemoDataTable() As DataTable
		Dim periodicTable As New DataTable("PeriodicTable")

		periodicTable.Columns.Add("Name", GetType(String))
		periodicTable.Columns.Add("Symbol", GetType(String))
		periodicTable.Columns.Add("AtomicNumber", GetType(Integer))

		Dim dr As DataRow = periodicTable.Rows.Add()
		dr(0) = "Hydrogen"
		dr(1) = "H"
		dr(2) = "1"

		dr = periodicTable.Rows.Add()
		dr(0) = "Helium"
		dr(1) = "He"
		dr(2) = "2"

		dr = periodicTable.Rows.Add()
		dr(0) = "Lithium"
		dr(1) = "Li"
		dr(2) = "3"

		dr = periodicTable.Rows.Add()
		dr(0) = "Beryllium"
		dr(1) = "Be"
		dr(2) = "4"

		dr = periodicTable.Rows.Add()
		dr(0) = "Boron"
		dr(1) = "B"
		dr(2) = "5"

		dr = periodicTable.Rows.Add()
		dr(0) = "Carbon"
		dr(1) = "C"
		dr(2) = "6"

		Return periodicTable
	End Function
End Class
