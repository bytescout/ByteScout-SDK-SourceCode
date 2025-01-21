'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing
Imports System.Drawing.Imaging
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
            ' Load PDF document
			_rasterRenderer.LoadDocumentFromFile(_document)
		Catch exception As Exception
            MessageBox.Show("Could not open PDF document." & vbLf & vbLf & exception.Message)
		Finally
			Cursor = Cursors.[Default]
		End Try
	End Sub

    Private Sub buttonPageSetup_Click(ByVal sender As Object, ByVal e As EventArgs)

        ' Set landscape orientation if needed
        Dim pageRectangle As RectangleF = _rasterRenderer.GetPageRectangle(0)
        If (pageRectangle.Width > pageRectangle.Height) Then
            pageSetupDialog1.PageSettings.Landscape = True
        End If

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
            ' For the best quality set the rendering resolution equal to the printer resolution
            Dim renderingResolution As Single = e.PageSettings.PrinterResolution.X

            ' Render page to image
            Using image As Image = _rasterRenderer.GetImage(_page, renderingResolution)

                ' Fit image into the print rectangle keeping the aspect ratio

                Dim printRect As Rectangle = e.MarginBounds

                Dim ratio As Single = printRect.Width / CSng(image.Width)
                Dim width As Integer = printRect.Width
                Dim height As Integer = CInt(Math.Round(image.Height * ratio))

                If height > printRect.Height Then
                    ratio = printRect.Height / CSng(image.Height)
                    width = CInt(Math.Round(image.Width * ratio))
                    height = printRect.Height
                End If

                ' Draw image on device
                e.Graphics.DrawImage(image, New Rectangle(printRect.X, printRect.Y, width, height), New Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel)

            End Using

            If _page < _rasterRenderer.GetPageCount() - 1 Then
                _page += 1
                e.HasMorePages = True
            End If
        Catch exception As Exception
            MessageBox.Show(exception.Message)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub
End Class
