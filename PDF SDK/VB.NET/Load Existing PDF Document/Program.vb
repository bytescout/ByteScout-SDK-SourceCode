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
''' This example demonstrates how to load and modify an existing document.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new Document object
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        '  Load existing document
        pdfDocument.Load("sample.pdf")

        ' Add new page to loaded document
        Dim page As New Page(PaperFormat.A4)
        Dim font As New Font(StandardFonts.Times, 24)
        Dim brush As New SolidBrush()
        page.Canvas.DrawString("New Page", font, brush, 20, 20)
        pdfDocument.Pages.Add(page)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
