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
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        Barcode.Symbology = SymbologyType.Codabar
        ' Set value
        Barcode.Value = "123456"

        ' Turn off caption
        barcode.DrawCaption = False

        ' Save barcode to image
        Barcode.SaveImage("result.png")

        ' Show image in default image viewer
        Process.Start("result.png")

    End Sub

End Module
