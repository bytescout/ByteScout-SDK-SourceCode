'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
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
