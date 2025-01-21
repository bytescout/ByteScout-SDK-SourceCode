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
''' This example demonstrates how to use templates.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
		pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
		
        ' If you wish to load an existing document uncomment the line below And comment the Add page section instead
        ' pdfDocument.Load(".\existing_document.pdf")

        ' Prepare simple template (for example, a logo) and draw it on every page:

        ' Create template of specified size
        Dim template = New GraphicsTemplate(250, 50)
        ' Draw the logo
        template.DrawRectangle(New SolidBrush(New ColorRGB(192, 192, 255)), 0, 0, 250, 50)
        template.DrawString("My Company Logo", New Font(StandardFonts.TimesBoldItalic, 24), New SolidBrush(), 30, 10)

        ' Add few pages and draw the prepared template on each one
        For i As Integer = 0 To 2
            Dim page = New Page(PaperFormat.A4)
            page.Canvas.DrawTemplate(template, 10, 10)
            pdfDocument.Pages.Add(page)
        Next

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
