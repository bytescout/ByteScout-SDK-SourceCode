'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.Drawing
Imports Bytescout.BarCode

Module Module1

    Sub Main()

        ' Create and activate QRCode instance
        Using barcode As New QRCode()

            barcode.RegistrationName = "demo"
            barcode.RegistrationKey = "demo"

            ' Set background color
            barcode.BackColor = Color.Yellow
            ' Set foreground color
            barcode.ForeColor = Color.Red

            ' Set value            
            barcode.Value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz 1234567890"

            ' Save barcode image to file
            barcode.SaveImage("result.png")

        End Using

        ' Open the image in default image viewer (for demo purpose)
        Process.Start("result.png")

    End Sub

End Module
