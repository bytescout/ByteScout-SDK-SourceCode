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


Imports Bytescout.BarCode

Module Program

    Sub Main()

        Try

            ' Create and activate barcode generator instance
            Using barcode As Barcode = New Barcode("demo", "demo")

                ' Set barcode type
                barcode.Symbology = SymbologyType.QRCode

                ' Set JSON string as a value
                barcode.Value = "{ 'name':'John', 'age':30, 'cars':[ 'Ford', 'BMW', 'Fiat' ] }"

                ' Save barcode to image file
                barcode.SaveImage("result.png")

            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        ' Show image in default image viewer
        Process.Start("result.png")

    End Sub

End Module
