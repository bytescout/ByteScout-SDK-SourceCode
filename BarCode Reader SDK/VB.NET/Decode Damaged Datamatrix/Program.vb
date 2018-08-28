'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports Bytescout.BarCodeReader

Module Program

    Sub Main()

        Try
            ' Create and activate Bytescout.BarCodeReader.Reader instance
            Using reader As Reader = New Reader("demo", "demo")

                ' Set barcode type to find
                reader.BarcodeTypesToFind.DataMatrix = True

                ' Read barcodes
                Dim barcodes() As FoundBarcode = reader.ReadFrom("corrupted_barcode_datamatrix.png")

                For Each code As FoundBarcode In barcodes
                    Console.WriteLine("Found barcode with type '{0}' and value '{1}'", code.Type, code.Value)
                Next

            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module
