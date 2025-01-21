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

Module Module1

    Sub Main()
        Dim bPrinter As New BarcodePrinter()
        bPrinter.Print(SymbologyType.Code39, "0123456789", "Case Number", 3.5F, 1.0F)
    End Sub

End Module
