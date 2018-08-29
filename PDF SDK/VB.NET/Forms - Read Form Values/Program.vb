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
        Dim pdfDocument = New Document("form.pdf")
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        Dim page = pdfDocument.Pages(0)

        ' Get widget by its name and get value
        Dim box1 = DirectCast(page.Annotations("editBox1"), EditBox).Text
        Dim box2 = DirectCast(page.Annotations("editBox2"), EditBox).Text
        Dim checkBox1 = DirectCast(page.Annotations("checkBox1"), CheckBox).Checked

        ' Cleanup 
		pdfDocument.Dispose()

        ' Writing values to console
        Console.WriteLine("Form values are as follows:")
        Console.WriteLine(box1)
        Console.WriteLine(box2)
        Console.WriteLine(checkBox1)

        Console.WriteLine()
        Console.WriteLine("Press any key to exit....")
        Console.ReadLine()

    End Sub

End Class
