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

        ' Set Unicode barcode value
        barcode.Value = "日本"

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
