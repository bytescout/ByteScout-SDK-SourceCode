'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

Class Program

    Friend Shared Sub Main(args As String())

        Dim inputFile As String = "encrypted (password is 'password').pdf"

        Using splitter As New DocumentSplitter("demo", "demo")

            ' Handle `PasswordRequired` event
            AddHandler splitter.PasswordRequired, New PasswordEventHandler(AddressOf splitter_PasswordRequired)

            ' Ignore document permissions
            splitter.CheckPermissions = False

            ' Split document
            splitter.Split(inputFile, "part1.pdf", "part2.pdf", 3)
        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadKey()

    End Sub

    Private Shared Sub splitter_PasswordRequired(sender As Object, document As String, ByRef password As String)
        ' Ask user for password And put it to `Password` property.
        password = "password"
    End Sub

End Class
