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


Imports System.IO
Imports System.Windows.Forms
Imports Bytescout.BarCode

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()

        For Each st As SymbologyType In [Enum].GetValues(GetType(SymbologyType))
            cmbBarcodeType.Items.Add(st)
        Next

		cmbBarcodeType.SelectedIndex = 0
		cmbImageFormat.SelectedIndex = 0
	End Sub

    Private Sub btnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        folderBrowserDialog.Description = "Select output folder"

        If folderBrowserDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim fileNameTemplate As String = tbFileNameTemplate.Text & "." & Convert.ToString(cmbImageFormat.SelectedItem).ToLower()
        Dim counterStartAt As UInteger = CUInt(Math.Truncate(nudCounterStartAt.Value))
        Dim counterStepBy As UInteger = CUInt(Math.Truncate(nudCounterStepBy.Value))
        Dim counterDigits As UInteger = Convert.ToUInt32(cmbCounterDigits.Text)

        If Not fileNameTemplate.Contains("[N]") Then
            MessageBox.Show("File name template does not contain the counter placeholder [N]")
            Return
        End If

        Dim valueTemplate As String = tbValueTemplate.Text
        Dim valueStartAt As UInteger = CUInt(Math.Truncate(nudValueStartAt.Value))
        Dim valueStepBy As UInteger = CUInt(Math.Truncate(nudValueStepBy.Value))
        Dim valueEndAt As UInteger = CUInt(Math.Truncate(nudValueEndAt.Value))
        Dim valueDigits As UInteger = Convert.ToUInt32(cmbValueDigits.Text)

        If Not valueTemplate.Contains("[N]") Then
            MessageBox.Show("Barcode value template does not contain the counter placeholder [N]")
            Return
        End If

        Cursor = Cursors.WaitCursor
        progressBar.Visible = True
        btnGenerate.Text = "Stop"

        Try
            progressBar.Value = CInt(valueStartAt)
            progressBar.Minimum = CInt(valueStartAt)
            progressBar.Maximum = CInt(valueEndAt)
            progressBar.Step = CInt(valueStepBy)

            GenerateBarcodes(valueTemplate, valueStartAt, valueEndAt, valueStepBy, valueDigits, fileNameTemplate, _
             counterStartAt, counterStepBy, counterDigits, folderBrowserDialog.SelectedPath)
        Catch exception As Exception
            MessageBox.Show(exception.Message)
        Finally
            Cursor = Cursors.Default
            progressBar.Visible = False
            btnGenerate.Text = "Generate multiple barcodes"
        End Try
    End Sub

	Private Sub GenerateBarcodes(valueTemplate As String, valueStartAt As UInteger, valueEndAt As UInteger, valueStepBy As UInteger, valueDigits As UInteger, fileNameTemplate As String, _
		counterStartAt As UInteger, counterStepBy As UInteger, counterDigits As UInteger, outputFolder As String)
		Dim barcode As New Barcode()
		barcode.RegistrationKey = "demo"
		barcode.RegistrationName = "demo"

		barcode.Symbology = CType(cmbBarcodeType.SelectedItem, SymbologyType)
		' Set up additional barcode properties here.
		'barcode.AdditionalCaption = "...";

		Dim c As UInteger = counterStartAt

		Dim i As UInteger = valueStartAt
		While i <= valueEndAt
            Dim value As String = String.Format("{0:D" & valueDigits & "}", i)
            Dim counter As String = String.Format("{0:D" & counterDigits & "}", c)
			Dim fileName As String = fileNameTemplate.Replace("[N]", counter)

			progressBar.PerformStep()

			barcode.Value = valueTemplate.Replace("[N]", value)

			barcode.SaveImage(Path.Combine(outputFolder, fileName))

			c += counterStepBy

			Application.DoEvents()
			i += valueStepBy
		End While
	End Sub
End Class
