'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.BarCodeReader


Public Partial Class _Default
    Inherits Web.UI.Page

    Protected Sub UploadButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim savePath As String = "\uploads\"

        If FileUpload1.HasFile Then
            Dim fileName As [String] = FileUpload1.FileName
            savePath += fileName
            FileUpload1.SaveAs(Server.MapPath(savePath))

            Dim barcodeReader As New Reader()

            ' Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
			' Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
			' or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
			barcodeReader.BarcodeTypesToFind.SetAll1D()
            
            'reader.MediumTrustLevelCompatible = true ' uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)

            UploadStatusLabel.Visible = False
            ListBox1.Items.Clear()
            ListBox1.Visible = True

            ListBox1.Items.Add("Reading barcode(s) from PDF file """ + fileName + """")

            Dim barcodes As FoundBarcode() = barcodeReader.ReadFrom(Server.MapPath(savePath))

            If barcodes.Length = 0 Then
                ListBox1.Items.Add("No barcodes found")
            Else
                For Each barcode As FoundBarcode In barcodes
                    ListBox1.Items.Add(String.Format("Found barcode with type '{0}' and value '{1}' at page {2} at {3}", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString()))
                Next
            End If

        Else
            ' Notify the user that a file was not uploaded.
            UploadStatusLabel.Text = "You did not specify a file to upload."
        End If
    End Sub
End Class
