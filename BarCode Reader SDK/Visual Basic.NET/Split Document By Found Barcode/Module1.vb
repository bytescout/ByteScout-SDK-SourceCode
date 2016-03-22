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

        Const inputFile As String = "Barcodes.pdf"

        Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(inputFile))

        ' Create Bytescout.BarCodeReader.Reader instance
        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Set barcode type to find
        reader.BarcodeTypesToFind.Code39 = True

        ' Find barcode in PDF document
        reader.ReadFrom(inputFile)

        ' Method 1: Split PDF document in two parts by found barcode
        ' NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only

        reader.SplitDocument("barcodes.pdf", "part1.pdf", "part2.pdf", reader.FoundBarcodes(0).Page + 1)

        ' Method 2: Extract page containing the barcode from PDF document
        ' NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only

        reader.ExtractPageFromDocument("barcodes.pdf", "extracted_page.pdf", reader.FoundBarcodes(0).Page + 1)

    End Sub

End Module
