'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Imports Bytescout.BarCode

Module Module1

    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.Codabar
        ' Set value
        barcode.Value = "123456"

        ' Set rendering hint
        barcode.RenderingHint = TextRenderingHint.ClearTypeGridFit
        ' Set smoothing mode
        barcode.SmoothingMode = SmoothingMode.AntiAlias

        ' Save barcode to image
        barcode.SaveImage("result.png")

        ' Show image in default image viewer
        Process.Start("result.png")
    End Sub

End Module
