'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Bytescout.Spreadsheet

Public Partial Class Form1
	Inherits Form
	Private _spreadsheetControl As SpreadsheetControl = Nothing

	Private _fileName As String = Nothing

	Public Sub New(args As String())
		If args.Length > 0 AndAlso File.Exists(args(0)) Then
			_fileName = args(0)
		End If

		If _fileName IsNot Nothing Then
			OpenFile(_fileName)
		End If

		InitializeComponent()
	End Sub

	Private Sub OpenFile(fileName As String)
		Text = "Spreadsheet Viewer - " & fileName

		Dim xls As New Spreadsheet()
		xls.RegistrationName = "demo"
		xls.RegistrationKey = "demo"

		Try
			xls.LoadFromFile(fileName)
		Catch generatedExceptionName As SpreadsheetProtectionPasswordRequired
			Dim passwordDialog As New PasswordDialog()

			If passwordDialog.ShowDialog(Me) = DialogResult.OK Then
				xls.LoadFromFile(fileName, CacheType.Memory, ",", Encoding.[Default], passwordDialog.Password)
			Else
				Return
			End If
		End Try

		lblStub.Visible = False

		If _spreadsheetControl Is Nothing Then
			_spreadsheetControl = New SpreadsheetControl()
			_spreadsheetControl.Dock = DockStyle.Fill

			Controls.Add(_spreadsheetControl)

			_spreadsheetControl.BringToFront()
			_spreadsheetControl.Focus()
		End If

		Cursor = Cursors.WaitCursor

		Try
			_spreadsheetControl.Spreadsheet = xls
		Catch e As Exception
			MessageBox.Show(e.ToString())
		Finally
			Cursor = Cursors.[Default]
		End Try
	End Sub

	Private Sub tsmiOpen_Click(sender As Object, e As EventArgs)
		If openFileDialog.ShowDialog() = DialogResult.OK Then
			OpenFile(openFileDialog.FileName)
		End If
	End Sub

	Private Sub tsmiAbout_Click(sender As Object, e As EventArgs)
		MessageBox.Show("Spreadsheet Viewer" & vbLf & vbLf & "www.bytescout.com" & vbLf & vbLf & "Copyright (c) Bytescout Software 2012", "About...")
	End Sub

	Private Sub tsmiExit_Click(sender As Object, e As EventArgs)
		Close()
	End Sub

	Private Sub tsmiVisitWebsite_Click(sender As Object, e As EventArgs)
		System.Diagnostics.Process.Start("http://www.bytescout.com")
	End Sub

	Private Sub tsbPromo_Click(sender As Object, e As EventArgs)
		System.Diagnostics.Process.Start("http://bytescout.com/products/developer/spreadsheetsdk/bytescoutspreadsheetsdk.html")
	End Sub
End Class
