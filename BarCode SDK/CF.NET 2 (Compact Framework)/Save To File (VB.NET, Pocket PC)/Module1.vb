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

        Dim bc As Barcode
        bc = New Barcode(SymbologyType.DataMatrix)
        bc.Value = "012345test"
        bc.SaveImage("TestBarcode.bmp")
    End Sub

End Module
