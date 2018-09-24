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

Module Program

    Sub Main()

        Try
            Dim doc As Document = New Document
            doc.Load("sample.pdf")

            ' Swap first and second pages:
            Dim tmp As Page = doc.Pages(1)
            doc.Pages.Remove(1)
            doc.Pages.Insert(0, tmp)

            'Save output file
            doc.Save("result.pdf")

            'Open output file
            Process.Start("result.pdf")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module
