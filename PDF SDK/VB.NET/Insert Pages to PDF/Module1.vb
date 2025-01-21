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
        Dim processStartInfo As New ProcessStartInfo("MergedDocument.pdf")
        processStartInfo.UseShellExecute = True
        Process.Start(processStartInfo)

    End Sub

End Module
