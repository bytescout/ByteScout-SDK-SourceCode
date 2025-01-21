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
Imports Bytescout.PDFViewer

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Protected Overrides Sub OnLoad(e As EventArgs)
		pdfViewerControl1.InputFile = "sample.pdf"

		MyBase.OnLoad(e)
	End Sub

    Private Sub tsbOpen_Click(sender As Object, e As EventArgs) Handles tsbOpen.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Open PDF Document"
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files|*.*"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Me.Text = openFileDialog.FileName

                Cursor = Cursors.WaitCursor

                Try
                    pdfViewerControl1.InputFile = openFileDialog.FileName
                Catch exception As Exception
                    MessageBox.Show(exception.Message)
                Finally
                    Cursor = Cursors.[Default]
                End Try
            End If
        End Using
    End Sub

    Private Sub cbMultiSelectMode_CheckedChanged(sender As Object, e As EventArgs) Handles cbMultiSelectMode.CheckedChanged
        pdfViewerControl1.MultiSelectMode = cbMultiSelectMode.Checked
    End Sub

    Private Sub cbAllowResizeSelection_CheckedChanged(sender As Object, e As EventArgs) Handles cbAllowResizeSelection.CheckedChanged
        pdfViewerControl1.AllowResizeSelectionRectangles = cbAllowResizeSelection.Checked
    End Sub

    Private Sub cbLockSelection_CheckedChanged(sender As Object, e As EventArgs) Handles cbLockSelection.CheckedChanged
        pdfViewerControl1.LockSelection = cbLockSelection.Checked
    End Sub

	Private _labels As List(Of [String]) = New List(Of String)()

    Private Sub pdfViewerControl1_SelectionChanged(ByVal sender As Object, ByVal selectionChange As SelectionChange, ByVal selectionIndex As Integer) Handles pdfViewerControl1.SelectionChanged
        If pdfViewerControl1.Selection.Length > _labels.Count Then
            For i As Integer = _labels.Count To pdfViewerControl1.Selection.Length - 1
                _labels.Add(New Random().[Next]().ToString())
            Next
        End If
    End Sub

    Private Sub pdfViewerControl1_CustomPaint(sender As Object, e As PaintEventArgs) Handles pdfViewerControl1.CustomPaint
        ' Paint labels
        For i As Integer = 0 To pdfViewerControl1.Selection.Length - 1
            Dim pdfRect As RectangleF = pdfViewerControl1.SelectionInPoints(i)
            Dim pixelRect As Rectangle = pdfViewerControl1.TranslateRectangleFromPointsToPixels(pdfRect)

            Dim textSize As Size = TextRenderer.MeasureText(_labels(i), Font)
            Dim textRectangle As New Rectangle(pixelRect.Left, pixelRect.Top - textSize.Height - 6, textSize.Width + 2, textSize.Height + 2)

            e.Graphics.FillRectangle(Brushes.DarkBlue, textRectangle)
            TextRenderer.DrawText(e.Graphics, _labels(i), Font, textRectangle, Color.White, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        Next
    End Sub
End Class
