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


Imports Bytescout.BarCodeReader

Partial Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Image1.ImageUrl = "BarcodePhoto.jpg"

        Dim reader As New Reader()

        ' Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
		' Change to reader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
		' or select specific type, e.g. reader.BarcodeTypesToFind.PDF417 = True
		reader.BarcodeTypesToFind.SetAll1D()

        'reader.MediumTrustLevelCompatible = true ' uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)

        reader.ReadFromFile(Server.MapPath("BarcodePhoto.jpg"))

        For Each barcode As FoundBarcode In reader.FoundBarcodes
            ListBox1.Items.Add([String].Format("{0} : {1}", barcode.Type, barcode.Value))
        Next

    End Sub

End Class
