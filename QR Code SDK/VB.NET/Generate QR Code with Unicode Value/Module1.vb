'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Text
Imports Bytescout.BarCode

Module Module1

    Sub Main()

        ' Create and activate QRCode instance
        Using barcode As New QRCode()

            barcode.RegistrationName = "demo"
            barcode.RegistrationKey = "demo"

            ' Set the character encoding to UTF8
            barcode.CharacterEncoding = Encoding.UTF8

            ' Set Unicode barcode value
            barcode.Value = "??"

            ' Show barcode caption (optional)
            barcode.DrawCaption = True

            ' Save barcode image to file
            barcode.SaveImage("result.png")

        End Using

        ' Open the image in default image viewer (for demo purpose)
        Process.Start("result.png")

    End Sub

End Module
