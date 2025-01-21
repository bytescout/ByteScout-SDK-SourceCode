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
''' This example demonstrates how to draw right-to-left text.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        ' If you wish to load an existing document uncomment the line below And comment the Add page section instead
        ' pdfDocument.Load(".\existing_document.pdf")

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
