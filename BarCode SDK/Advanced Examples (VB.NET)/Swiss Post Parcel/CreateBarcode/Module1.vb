'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.BarCode

Module Module1

    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.SwissPostParcel

        ' Set value
        barcode.Value = "123456789012345678"

        ' Save barcode to image
        barcode.SaveImage("result.png")

        ' Show image in default image viewer
        Process.Start("result.png")
    End Sub

End Module
