'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.BarCode

Module Module1

    Sub Main()
        Dim bPrinter As New BarcodePrinter()
        bPrinter.Print(SymbologyType.Code39, "0123456789", "Case Number", 3.5F, 1.0F)
    End Sub

End Module
