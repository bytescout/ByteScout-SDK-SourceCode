'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
