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
