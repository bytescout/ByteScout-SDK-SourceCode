'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Diagnostics
Imports System.Text
Imports Bytescout.BarCode

Class Program

    Friend Shared Sub Main(ByVal args As String())

        ' Create and activate QRCode component instance
        Using barcode As New QRCode()

            barcode.RegistrationName = "demo"
            barcode.RegistrationKey = "demo"
            
            ' Sample byte array to use as value  
            Dim byteArray As Byte() = New Byte() {0, 10, 11, 12, 13, 14, 15, &HFF}

            ' Set value by converting byte array to string  
            barcode.Value = Encoding.ASCII.GetString(byteArray)

            ' Save barcode image
            barcode.SaveImage("result.png")

        End Using

        ' Open the image in default associated application (for the demo purpose)
        Process.Start("result.png")

    End Sub

End Class
