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
Imports System.Drawing.Imaging
Imports System.IO
Imports Bytescout.BarCodeReader

Module Module1

    Dim i As Int32 = 0

    Sub Main()

        Const imageFile As String = "Code_39.png"

        Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(imageFile))

        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Set barcode type to find
        reader.BarcodeTypesToFind.Code39 = True

        ' Handle Barcode Reader's Inspect Decoded Barcodes event
        AddHandler reader.InspectDecodedBarcodes, AddressOf Reader_InspectDecodedBarcodes

        ' Read barcodes
        Dim barcodes As FoundBarcode() = reader.ReadFrom(imageFile)

        For Each barcode As FoundBarcode In barcodes
            Console.WriteLine("Found barcode with type '{0}' and value '{1}'", barcode.Type, barcode.Value)
        Next

        ' Cleanup
        reader.Dispose()

        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

    ''' <summary>
    ''' Inspect decoded barcode event handler
    ''' </summary>
    Private Sub Reader_InspectDecodedBarcodes(sender As Object, image As Image)
        Dim imageName = "page" + (++i).ToString() + ".png"
        image.Save(imageName, ImageFormat.Png)

        Console.WriteLine("Inspected barcode saved as " + imageName)

        ' You should explicitly dispose the image object to avoid resource leaks.
        image.Dispose()
    End Sub

End Module
