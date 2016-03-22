'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

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

        ' Set custom caption
        barcode.Caption = "Custom caption"
        ' Set caption font
        barcode.CaptionFont = New Font("Comic Sans MS", 12)
        ' Set caption position
        barcode.CaptionPosition = CaptionPosition.Above

        ' Save barcode to image
        barcode.SaveImage("result.png")

        ' Show image in default image viewer
        Process.Start("result.png")
    End Sub

End Module
