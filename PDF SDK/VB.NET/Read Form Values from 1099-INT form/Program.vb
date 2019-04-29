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
        Dim pdfDocument = New Document("f1099int_filled.pdf")
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        ' Read from second page
        Dim page = pdfDocument.Pages(1)


        Console.WriteLine("F1099int_filled Form values are as follows")

        ' Is Void
        Dim lIsVoid = DirectCast(page.Annotations("c2_1[0]"), CheckBox).Checked
        Console.WriteLine($"Is Void: {lIsVoid}")

        ' Payer's info
        Dim cPayerInfo = DirectCast(page.Annotations("f2_1[0]"), EditBox).Text
        Console.WriteLine($"Payer Info: {cPayerInfo}")

        ' Payer's TIN
        Dim cPayerTin = DirectCast(page.Annotations("f2_2[0]"), EditBox).Text
        Console.WriteLine($"Payer TIN: {cPayerTin}")

        ' Recipient's TIN
        Dim cRecipientTin = DirectCast(page.Annotations("f2_4[0]"), EditBox).Text
        Console.WriteLine($"Recipient TIN: {cRecipientTin}")

        ' Street Address 1
        Dim cStreetAddress1 = DirectCast(page.Annotations("f2_5[0]"), EditBox).Text
        Console.WriteLine($"Street Address - 1: {cStreetAddress1}")

        ' Street Address 2
        Dim cStreetAddress2 = DirectCast(page.Annotations("f2_6[0]"), EditBox).Text
        Console.WriteLine($"Street Address - 2: {cStreetAddress2}")

        ' Cleanup 
        pdfDocument.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to exit....")
        Console.ReadLine()

    End Sub

End Class
