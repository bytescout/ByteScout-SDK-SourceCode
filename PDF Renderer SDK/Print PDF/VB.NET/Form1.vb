'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Text
Imports System.Windows.Forms

Imports Bytescout.PDFRenderer


Public Partial Class Form1
	Inherits Form
	Private _document As String = "multipage.pdf"
	Private _rasterRenderer As RasterRenderer = Nothing
	Private _page As Integer = 0


	Public Sub New()
		InitializeComponent()

		' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
		_rasterRenderer = New RasterRenderer()
		_rasterRenderer.RegistrationName = "demo"
		_rasterRenderer.RegistrationKey = "demo"
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs)
		Cursor = Cursors.WaitCursor

		Try
			' Load PDF document.
			_rasterRenderer.LoadDocumentFromFile(_document)
		Catch exception As Exception
			MessageBox.Show("Failed to open PDF document." & vbCr & vbLf & exception.Message)
		Finally
			Cursor = Cursors.[Default]
		End Try
	End Sub

	Private Sub buttonPageSetup_Click(sender As Object, e As EventArgs)
		pageSetupDialog1.ShowDialog()
	End Sub

	Private Sub buttonPrintPreview_Click(sender As Object, e As EventArgs)
		_page = 0
		printPreviewDialog1.Width = 800
		printPreviewDialog1.Height = 600
		printPreviewDialog1.ShowDialog()
	End Sub

	Private Sub buttonPrint_Click(sender As Object, e As EventArgs)
		If printDialog1.ShowDialog() = DialogResult.OK Then
			printDocument1.Print()
		End If
	End Sub

	Private Sub printDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs)
		Cursor = Cursors.WaitCursor

		Try
			Using vectorRenderer As New VectorRenderer("demo", "demo")
				vectorRenderer.LoadDocumentFromFile(_document)

				Dim printRect As Rectangle = e.MarginBounds

				Using image As Metafile = vectorRenderer.RenderPageToMetafile(_page)
					' calculate print rectangle
					Dim ratio As Single = printRect.Width / CSng(image.Width)
					Dim width As Integer = printRect.Width
					Dim height As Integer = CInt(Math.Truncate(image.Height * ratio))

					If height > printRect.Height Then
						ratio = printRect.Height / CSng(image.Height)
						width = CInt(Math.Truncate(image.Width * ratio))
						height = printRect.Height
					End If

					' draw page on device
					e.Graphics.DrawImage(image, New Rectangle(printRect.X, printRect.Y, width, height), New Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel)
				End Using

				If _page < vectorRenderer.GetPageCount() - 1 Then
					_page += 1
					e.HasMorePages = True
				End If
			End Using
		Finally
			Cursor = Cursors.[Default]
		End Try
	End Sub
End Class
