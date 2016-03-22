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
        ' Get all JPG files from the current folder
        Dim filesToScan As String() = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.jpg")

        ' Create barcode reader instance
        Using bc As New Reader()
        	
	        bc.RegistrationName = "demo"
			bc.RegistrationKey = "demo"

            ' Set up to search for EAN13 barcodes only to speed up the processing
            bc.BarcodeTypesToFind.EAN13 = True
            ' Set up to scan horizontal barcodes only to speed up the processing
            bc.Orientation = OrientationType.HorizontalFromLeftToRight

            ' Iterate over images and read barcodes
            For i As Integer = 0 To filesToScan.Length - 1

                Console.WriteLine("Reading barcode(s) from image {0}", filesToScan(i))

                ' Read barcodes from image
                Dim barcodes As FoundBarcode() = bc.ReadFrom(filesToScan(i))

                ' Write out results to console
                For Each barcode As FoundBarcode In barcodes
                    Console.WriteLine("Found barcode with type '{0}' and value '{1}'", barcode.Type, barcode.Value)
                Next

                Console.WriteLine()

            Next

        End Using

        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

End Module
