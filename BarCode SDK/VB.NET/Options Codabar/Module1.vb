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


Imports Bytescout.BarCode

Module Module1

    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.Codabar
        ' Set value
        barcode.Value = "123456"

        ' Checksum algorithm
        barcode.Options.CodabarChecksumAlgorithm = CodabarChecksumAlgorithm.Modulo9
        ' Start symbol
        barcode.Options.CodabarStartSymbol = CodabarSpecialSymbol.C
        ' Stop symbol
        barcode.Options.CodabarStopSymbol = CodabarSpecialSymbol.A

        ' Draw intercharacter gap
        barcode.Options.DrawIntercharacterGap = True
        ' Show start/stop symbols
        barcode.Options.ShowStartStop = True

        ' Save barcode to image
        barcode.SaveImage("result.png")

        ' Show image in default image viewer
        Process.Start("result.png")
    End Sub

End Module
