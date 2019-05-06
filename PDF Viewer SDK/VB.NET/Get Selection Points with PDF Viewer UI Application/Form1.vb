'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System.Drawing
Imports System.Windows.Forms

Partial Public Class Form1
    Inherits Form

    Public Sub New()
        InitializeComponent()

        ' Assign default document
        pdfViewerControl1.InputFile = "sample.pdf"

        ' Initially set selection
        pdfViewerControl1.Selection = New Rectangle() {New Rectangle(20, 20, 100, 100)}

        ' Get Selection Information
        GetSelectionInformation()

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

    Private Sub btnGetSelectionPoints_Click(sender As Object, e As EventArgs) Handles btnGetSelectionPoints.Click
        GetSelectionInformation()
    End Sub

    Private Sub GetSelectionInformation()
        If pdfViewerControl1.SelectionInPoints.Length > 0 Then

            ' If need to get selection in PDF format then use .SelectionInPoints that returns coordinates in PDF points. 
            ' PDF points can be used with other SDK to extract text, draw on pdf, add text, images etc. 
            ' These PDF points coordinates are staying the same with any rendering resolution for PDF because resolution affects only how pdf Is converted into displaying image.
            Dim selectionInPoints As RectangleF = pdfViewerControl1.SelectionInPoints(0)
            txtSelectionPDFUnit.Text = String.Format("Top={0}, Left={1}, Bottom={2}, Right={3}, Width={4}, Height={5}",
                    selectionInPoints.Top,
                    selectionInPoints.Left,
                    selectionInPoints.Bottom,
                    selectionInPoints.Right,
                    selectionInPoints.Width,
                    selectionInPoints.Height)

            ' If you need to draw on screen on the control then please use .Selection property to get coordinates. 
            Dim selectionInPixels As RectangleF = pdfViewerControl1.Selection(0)
            txtSelectionPixel.Text = String.Format("Top={0}, Left={1}, Bottom={2}, Right={3}, Width={4}, Height={5}",
                selectionInPixels.Top.ToString(),
                selectionInPixels.Left.ToString(),
                selectionInPixels.Bottom.ToString(),
                selectionInPixels.Right.ToString(),
                selectionInPixels.Width,
                selectionInPixels.Height)

        Else
            MessageBox.Show("Selection not available.")
        End If
    End Sub


End Class
