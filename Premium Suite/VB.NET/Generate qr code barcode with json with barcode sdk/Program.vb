'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
