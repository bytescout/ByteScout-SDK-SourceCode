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
