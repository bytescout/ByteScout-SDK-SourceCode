'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Bytescout.BarCodeReader

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

    Private _fileName As String = ""

	Private Sub buttonBrowse_Click(sender As Object, e As EventArgs)
		Dim result As DialogResult = openFileDialog.ShowDialog()

		If result = DialogResult.OK Then
			_fileName = openFileDialog.FileName
			textBoxFileName.Text = _fileName

			Try
				Dim bmp As New Bitmap(_fileName)
				pictureBoxBarcode.Image = bmp
			Catch generatedExceptionName As Exception
				pictureBoxBarcode.Image = Nothing
			End Try
		End If
	End Sub

	Private Sub buttonSearchBarcodes_Click(sender As Object, e As EventArgs)
		FindBarcodes()
	End Sub

	Private Sub FindBarcodes()
        If String.IsNullOrEmpty(_fileName) Then
            Return
        End If

		Dim reader As New Reader()
		reader.RegistrationName = "demo"
		reader.RegistrationKey = "demo"

		If checkBoxAll1D.Checked Then
			reader.BarcodeTypesToFind.All1D = True
		End If
		If checkBoxAll2D.Checked Then
			reader.BarcodeTypesToFind.All2D = True
		End If

		Cursor = Cursors.WaitCursor

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

		Dim foundBarcodes As FoundBarcode() = reader.ReadFrom(_fileName)
		ResetCursor()

		Dim data As New List(Of String)()

		If foundBarcodes.Length = 0 Then
			data.Add("No barcodes found")
		Else
			For Each barcode As FoundBarcode In foundBarcodes
                data.Add(String.Format("Type ""{0}"" and value ""{1}""", barcode.Type, barcode.Value))
			Next
		End If

        ' Cleanup
        reader.Dispose()

        textBoxResults.Lines = data.ToArray()
	End Sub
End Class
