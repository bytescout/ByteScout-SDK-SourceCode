'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Windows.Forms

Public Partial Class Form1
    Inherits Form

	Public Sub New()
		InitializeComponent()
	End Sub

    Private Sub tsbOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbOpen.Click

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

    Private Sub PdfViewerControl1_PreProcessKey(source As Object, keyData As Keys, ByRef handled As Boolean) Handles pdfViewerControl1.PreProcessKey

        If keyData = (Keys.A Or Keys.Shift) Then
            MessageBox.Show("Shift-A")
            handled = True
        End If

        If keyData = (Keys.A Or Keys.Control Or Keys.Alt Or Keys.Shift) Then
            MessageBox.Show("Ctrl-Alt-Shift-A")
            handled = True
        End If

    End Sub

End Class
