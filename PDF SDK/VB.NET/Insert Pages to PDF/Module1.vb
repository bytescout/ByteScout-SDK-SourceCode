'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.PDF

Module Module1

    Sub Main()

        ' Open first document
        Dim document1 = New Document("document1.pdf")
        document1.RegistrationName = "demo"
        document1.RegistrationKey = "demo"

        ' Open second document
        Dim document2 = New Document("document2.pdf")
        document2.RegistrationName = "demo"
        document2.RegistrationKey = "demo"

        ' Page index to insert document
        Dim pageIndexToAdd As Int32 = 1

        ' Add pages from document2 to document1
        For i As Integer = 0 To document2.Pages.Count - 1
            document1.Pages.Insert(pageIndexToAdd, document2.Pages(i))
            pageIndexToAdd = pageIndexToAdd + 1
        Next

        ' Save merged document
        document1.Save("MergedDocument.pdf")

        ' Open merged document in default PDF viewer application
        Process.Start("MergedDocument.pdf")

    End Sub

End Module
