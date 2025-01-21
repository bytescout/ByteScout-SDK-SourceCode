'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to get PDF form values programmatically.
''' </summary>
Class Program

    Shared Sub Main()

        ' Load PDF form
        Dim pdfDocument = New Document("W-4_Filled.pdf")
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        ' Read from first page
        Dim page = pdfDocument.Pages(0)

        Console.WriteLine("W-4 Form values are as follows")

        ' FirstName And middle initial
        Dim cFirstName = DirectCast(page.Annotations("f1_01[0]"), EditBox).Text
        Console.WriteLine($"FirstName: {cFirstName}")

        ' LastName
        Dim cLastName = DirectCast(page.Annotations("f1_02[0]"), EditBox).Text
        Console.WriteLine($"LastName: {cLastName}")

        ' Security Number
        Dim cSecurityNumber = DirectCast(page.Annotations("f1_03[0]"), EditBox).Text
        Console.WriteLine($"Security Number: {cSecurityNumber}")

        ' Home Address
        Dim cHomeAddress = DirectCast(page.Annotations("f1_04[0]"), EditBox).Text
        Console.WriteLine($"Home Address-1: {cHomeAddress}")

        ' Home Address 2
        Dim cHomeAddress2 = DirectCast(page.Annotations("f1_05[0]"), EditBox).Text
        Console.WriteLine($"Home Address-2: {cHomeAddress2}")

        ' Is Married
        Dim bIsMarried = DirectCast(page.Annotations("c1_1[1]"), CheckBox).Checked
        Console.WriteLine($"Is Married: {bIsMarried}")

        ' Cleanup 
        pdfDocument.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to exit....")
        Console.ReadLine()

    End Sub

End Class
