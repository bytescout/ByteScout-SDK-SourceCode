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


Imports System.Drawing
Imports System.Drawing.Imaging
Imports Bytescout.BarCode

Module Program

    Sub Main()

        Try

            ' Create new barcode
            Using barcode As Barcode = New Barcode()

                barcode.RegistrationName = "demo"
                barcode.RegistrationKey = "demo"

                ' Set symbology
                barcode.Symbology = SymbologyType.PharmaCode

                ' Optional margins
                barcode.Margins = New Margins(5, 5, 5, 5)

                ' Set Value
                barcode.Value = "12345"

                ' Set PharmaCode options:
                ' barcode.Options.PharmaCodeSupplementaryCode = True
                ' barcode.Options.PharmaCodeSupplementaryBarColor = Color.Orange
                ' barcode.Options.PharmaCodeMiniature = True
                ' barcode.Options.PharmaCodeTwoTrack = True

                ' Save 300 DPI Image
                barcode.ResolutionX = 300
                barcode.ResolutionY = 300
                barcode.SaveImage("300dpi.png", ImageFormat.Png)

                ' Save 600 DPI Image
                barcode.ResolutionX = 600
                barcode.ResolutionY = 600
                barcode.SaveImage("600dpi.png", ImageFormat.Png)

            End Using

            ' Show image in default image viewer
            Process.Start("300dpi.png")
            Process.Start("600dpi.png")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()

    End Sub

End Module
