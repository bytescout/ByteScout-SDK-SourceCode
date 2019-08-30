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


Imports System.IO
Imports Bytescout.BarCodeReader

Module Module1

    Sub Main()

        Const imageFile As String = "1d_barcodes.pdf"

        Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(imageFile))

        Dim reader As New Reader()
        reader.RegistrationName = "demo"
		reader.RegistrationKey = "demo"

        ' Set barcode type to find
        reader.BarcodeTypesToFind.All1D = True

        AddHandler reader.BarcodeFound, AddressOf Reader_BarcodeFound

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

        ' Read barcodes
        reader.ReadFrom(imageFile)

        ' Cleanup
        reader.Dispose()

        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

    Private Sub Reader_BarcodeFound(ByVal sender As Object, ByVal e As BarcodeFoundEventArgs)

        Console.WriteLine("Found barcode with type '{0}' and value '{1}'", e.Barcode.Type, e.Barcode.Value)

        If e.Count = 5 Then
            ' Cancel after 5 barcodes found
            e.Cancel = True
            Console.WriteLine("Cancelled.")
        End If

    End Sub

End Module
