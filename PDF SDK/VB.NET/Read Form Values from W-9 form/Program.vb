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


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to get PDF form values programmatically.
''' </summary>
Class Program

    Shared Sub Main()

        ' Load PDF form
        Dim pdfDocument = New Document("W-9_Filled.pdf")
        pdfDocument.RegistrationName = "demo"
        pdfDocument.RegistrationKey = "demo"

        ' Read from first page
        Dim page = pdfDocument.Pages(0)

        Console.WriteLine("W-9 Form values are as follows")

        ' Name
        Dim cName = DirectCast(page.Annotations("f1_1[0]"), EditBox).Text
        Console.WriteLine($"Name: {cName}")

        ' Business Address
        Dim cAddress = DirectCast(page.Annotations("f1_2[0]"), EditBox).Text
        Console.WriteLine($"Address: {cAddress}")

        ' Cleanup 
        pdfDocument.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to exit....")
        Console.ReadLine()

    End Sub

End Class
