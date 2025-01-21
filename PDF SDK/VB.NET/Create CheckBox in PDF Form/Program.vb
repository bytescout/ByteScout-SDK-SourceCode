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
''' This example demonstrates how to create checkboxes.
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

        ' Add unchecked checkbox
        Dim checkBox1 = New CheckBox(20, 20, 15, 15, "checkBox1")
        page.Annotations.Add(checkBox1)

        ' Add checked checkbox
        Dim checkBox2 = New CheckBox(20, 40, 15, 15, "checkBox2")
        checkBox2.Checked = True
        page.Annotations.Add(checkBox2)

        ' Add readonly checkbox
        Dim checkBox3 = New CheckBox(20, 60, 15, 15, "checkBox3")
        checkBox3.Checked = True
        checkBox3.ReadOnly = True
        page.Annotations.Add(checkBox3)

        ' Draw text labels
        Dim font = New Font(StandardFonts.Times, 12)
        Dim brush = New SolidBrush()
        page.Canvas.DrawString("Unchecked box", font, brush, 45, 20)
        page.Canvas.DrawString("Checked box", font, brush, 45, 40)
        page.Canvas.DrawString("Read-only checked box", font, brush, 45, 60)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
