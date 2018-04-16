'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports System.IO

Imports Bytescout.BarCodeReader

Module Module1

    Sub Main()

        ' Get all JPG files from the current folder
        Dim filesToScan As String() = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.jpg")

        ' Open file to export results
        Dim resultsCsvFile As StreamWriter = File.CreateText("results.csv")

        ' Create barcode reader instance
        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Set barcode types for searching
        reader.BarcodeTypesToFind.EAN13 = True
        
        ' Iterate over images and read barcodes
        For Each file As String In filesToScan

            Console.WriteLine()
            Console.WriteLine("Reading barcode(s) from image {0}", file)

            ' Read barcodes from image
            Dim barcodes As FoundBarcode() = reader.ReadFrom(file)

            ' Display results in console
            For Each barcode As FoundBarcode In barcodes
                Console.WriteLine("Found barcode with type '{0}' and value '{1}'", barcode.Type, barcode.Value)
            Next

            ' Write results to file in CSV format. Note, you can also export to TXT and XML.
            Dim csv = reader.ExportFoundBarcodesToCSV()
            resultsCsvFile.Write(csv)

        Next

        reader.Dispose()
        resultsCsvFile.Dispose()


        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

End Module
