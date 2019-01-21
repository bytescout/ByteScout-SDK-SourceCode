'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System.IO
Imports Bytescout.BarCodeReader

Module Module1

    Sub Main()

        Dim ImageFile As String = "checkboxes-checked.png"

        Console.WriteLine("Reading checkboxes from image {0}", Path.GetFullPath(ImageFile))

        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Enable check boxes recognition
        reader.BarcodeTypesToFind.Checkbox = True


        ' Find check boxes
        Dim barcodes = reader.ReadFrom(ImageFile)

        For Each barcode As FoundBarcode In barcodes
            Console.WriteLine("Found checkbox with type '{0}' and value '{1}'", barcode.Type, barcode.Value)
        Next

        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

End Module
