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

Imports Bytescout.BarCode

Module Module1

    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.Codabar
        ' Set value
        barcode.Value = "123456"

        ' Set custom additional caption
        barcode.AdditionalCaption = "Custom caption"
        ' Set additional caption font
        barcode.AdditionalCaptionFont = New Font("Comic Sans MS", 12)
        ' Set additional caption position
        barcode.AdditionalCaptionPosition = CaptionPosition.Above

        ' Save barcode to image
        barcode.SaveImage("result.png")

        ' Show image in default image viewer
        Process.Start("result.png")
    End Sub

End Module
