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


Imports System.Drawing
Imports Bytescout.BarCode

Module Module1

    Sub Main()

        Using barcode As New Barcode("demo", "demo")

            barcode.Symbology = SymbologyType.Code128

            barcode.Margins = New Margins(0, 0, 0, 0)
            barcode.DrawQuietZones = False

            barcode.Value = "123123"
            Dim image1 As Image = barcode.GetImage()

            barcode.Value = "123"
            Dim image2 As Image = barcode.GetImage()

            Using composer As New ImageComposer(10, 5, CompositionMode.ArrangeHorizontally)

                composer.AddImage(image1)
                composer.AddImage(image2, 0, 0, 90)

                composer.SaveComposedImage("result.png")

                ' Show image in default image viewer
                Process.Start("result.png")

            End Using
        End Using
    End Sub

End Module
