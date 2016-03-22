'*******************************************************************
'       ByteScout BarCode Reader SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.IO

Imports Bytescout.BarCodeReader

Module Module1

    Sub Main()

        Const imageFile As String = "Aztec.png"

        Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(imageFile))

        Dim bc As New Reader()
        bc.RegistrationName = "demo"
		bc.RegistrationKey = "demo"

        ' Set barcode type to find
		bc.BarcodeTypesToFind.Aztec = True

        ' Read barcodes
        Dim barcodes As FoundBarcode() = bc.ReadFrom(imageFile)

        For Each barcode As FoundBarcode In barcodes
            Console.WriteLine("Found barcode with type '{0}' and value '{1}'", barcode.Type, barcode.Value)
        Next

        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

End Module
