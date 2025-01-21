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
''' This example demonstrates how to use fonts.
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

        Dim brush = New SolidBrush()

        ' Use standard PDF font
        Dim standardFont = New Font(StandardFonts.Times, 16)
        canvas.DrawString("Standard font.", standardFont, brush, 20, 20)

        ' Use font installed in system
        Dim systemFont = New Font("Arial", 16)
        canvas.DrawString("Windows font.", systemFont, brush, 20, 50)

        ' Use font loaded from file
        Dim fontFromFile = Font.FromFile("VeraBI.ttf", 16)
        canvas.DrawString("Font loaded from file.", fontFromFile, brush, 20, 80)


        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
