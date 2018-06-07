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


Imports Bytescout.BarCode
Imports System.Drawing

Module Module1

    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.QRCode

        ' set QR code encoding to UTF8 so will be able to encode Unicode 
        barcode.Options.Encoding = System.Text.Encoding.UTF8()

        ' Set barcode value to ?           
        barcode.Value = "?"

        ' show caption for 2d barcodes
        barcode.DrawCaptionFor2DBarcodes = True

        ' set caption font to Arial Unicode MS so it will display the caption
        barcode.CaptionFont = New Font("Arial Unicode MS", 8)

        ' Save barcode to image
        barcode.SaveImage("qrcode.png")

        ' Show image in default image viewer
        Process.Start("qrcode.png")

    End Sub

End Module
