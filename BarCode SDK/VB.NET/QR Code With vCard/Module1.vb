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


Imports Bytescout.BarCode

Module Module1

    Sub Main()

        ' Create and activate barcode generator instance
        Using barcode As New Barcode("demo", "demo")

            ' Set barcode type
            barcode.Symbology = SymbologyType.QRCode

            ' Inputs
            Dim inpEmail = New QrCodeVCardTemplate With {
                .FirstName = "Forest",
                .LastName = "Gump",
                .Company = "Bubba Gump Shrimp Co.",
                .Job = "Shrimp Man",
                .Phone = "+1-111-555-1212",
                .Fax = "+1-404-555-1212",
                .Email = "forrestgump@example.com",
                .Street = "100 Waters Edge",
                .City = "Baytown",
                .State = "LA",
                .Country = "USA",
                .ZipCode = "30314"
            }

            ' Set barcode value
            barcode.Value = inpEmail.ToString()

            ' Save generated barcode
            barcode.SaveImage("result.png")

            ' Open generated barcode image with associated application
            Process.Start("result.png")

        End Using

    End Sub

End Module
