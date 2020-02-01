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


Imports System.Text
Imports Bytescout.BarCodeReader

Class MainWindow

    ' Select image file
    Private Sub btnBrowse_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles btnBrowse.Click

        Dim dlg = New Microsoft.Win32.OpenFileDialog
        dlg.Filter = "Supported formats (*.bmp;*.gif;*.tif;*.png;*.jpg;*.pdf)|*.bmp;*.gif;*.tif;*.tiff;*.png;*.jpg;*.jpeg;*.pdf|All Files|*.*"

        If dlg.ShowDialog() = True Then

            tbFileName.Text = dlg.FileName
            tbFoundBarcodes.Text = ""
            imageContainer.Source = Nothing

            Try
                Dim bitmapImage = New BitmapImage()
                bitmapImage.BeginInit()
                bitmapImage.UriSource = New Uri(dlg.FileName, UriKind.Absolute)
                bitmapImage.EndInit()

                imageContainer.Source = bitmapImage

            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub btnDecode_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles btnDecode.Click

        ' Create barcode reader instance
        Dim reader = New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Specify barcode types to find
        reader.BarcodeTypesToFind.All = True
        ' Select specific barcode types to speed up the decoding process and avoid false positives.

        ' Show wait cursor
        Mouse.OverrideCursor = Cursors.Wait

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

        Try
            '  Search for barcodes
            reader.ReadFrom(tbFileName.Text)
        Finally
            Mouse.OverrideCursor = Nothing
        End Try

        ' Display found barcode inforamtion:

        Dim stringBuilder = New StringBuilder()

        For i As Integer = 0 To reader.FoundBarcodes.Length - 1
            Dim barcode = reader.FoundBarcodes(i)
            stringBuilder.AppendFormat("{0}) Type: {1}; Value: {2}.\r\n", i + 1, barcode.Type, barcode.Value)
        Next

        tbFoundBarcodes.Text = stringBuilder.ToString()

    End Sub

End Class
