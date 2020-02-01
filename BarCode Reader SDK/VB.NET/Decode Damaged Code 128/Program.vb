'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.BarCodeReader

Module Program

    Sub Main()

        Try

            ' Create and activate Bytescout.BarCodeReader.Reader instance
            Using reader As Reader = New Reader("demo", "demo")

                ' Set barcode type to find
                reader.BarcodeTypesToFind.Code128 = True

                ' -----------------------------------------------------------------------
                ' NOTE: We can read barcodes from specific page to increase performance .
                ' For sample please refer to "Decoding barcodes from PDF by pages" program.
                ' ----------------------------------------------------------------------- 

                ' Read barcodes
                Dim barcodes() As FoundBarcode = reader.ReadFrom("corrupted_barcode_code128.png")

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
