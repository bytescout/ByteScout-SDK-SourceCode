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
''' This example demonstrates how to change the intercharacter spacing.
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
