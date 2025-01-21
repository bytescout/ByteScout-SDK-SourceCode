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
Imports System.Diagnostics

Class Program

	Friend Shared Sub Main(args As String())

        Dim inputFiles As String() = New String() {"encrypted1 (password is 'password').pdf", "encrypted2 (password is 'password').pdf"}

        Using merger As New DocumentMerger("demo", "demo")

            ' Handle `PasswordRequired` event
            AddHandler merger.PasswordRequired, New PasswordEventHandler(AddressOf merger_PasswordRequired)

            ' Ignore document permissions
            merger.CheckPermissions = False

            merger.Merge(inputFiles, "result.pdf")
        End Using

        Process.Start("result.pdf")

    End Sub

    Private Shared Sub merger_PasswordRequired(sender As Object, document As String, ByRef password As String)
        ' Set document password here
        password = "password"
    End Sub
End Class
