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


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to change the intercharacter spacing.
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

        Dim canvas = page.Canvas

        Dim font = New Font("Arial", 16)
        Dim brush = New SolidBrush()
        Dim stringFormat = New StringFormat()

        ' Standard spacing
        stringFormat.CharacterSpacing = 0.0F
        canvas.DrawString("Standard intercharacter spacing 0.0", font, brush, 20, 20, stringFormat)

        ' Increased spacing 
        stringFormat.CharacterSpacing = 1.0F
        canvas.DrawString("Increased intercharacter spacing 1.0", font, brush, 20, 50, stringFormat)

        ' Reduced spacing
        stringFormat.CharacterSpacing = -0.75F
        canvas.DrawString("Reduced intercharacter spacing -0.75", font, brush, 20, 80, stringFormat)


        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
