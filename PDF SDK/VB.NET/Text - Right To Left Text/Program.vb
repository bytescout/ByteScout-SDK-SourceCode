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
''' This example demonstrates how to draw right-to-left text.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        ' Add page
        Dim page = New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page)

        Dim font = New Font("Arial", 16)
        Dim brush = New SolidBrush()

        ' Set right to left text direction
        Dim stringFormat = New StringFormat()
        stringFormat.DirectionRightToLeft = True

        page.Canvas.DrawString("???? ????? ?????", font, brush, page.Width - 20, 30, stringFormat)
        page.Canvas.DrawString("???, ?????, ????", font, brush, page.Width - 20, 50, stringFormat)
        page.Canvas.DrawString("?? ?? ??", font, brush, page.Width - 20, 70, stringFormat)


        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
