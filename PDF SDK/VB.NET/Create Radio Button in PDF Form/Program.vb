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
''' This example demonstrates how to create radio buttons.
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

        Dim font = New Font(StandardFonts.Times, 12)
        Dim brush = New SolidBrush()

        ' Add a group of radio buttons
        Dim radioButton1 = New RadioButton(20, 20, 15, 15, "group1", "value1")
        Dim radioButton2 = New RadioButton(20, 40, 15, 15, "group1", "value2")
        page.Annotations.Add(radioButton1)
        page.Annotations.Add(radioButton2)
        ' Add labels
        page.Canvas.DrawString("Value 1.1", font, brush, 40, 20)
        page.Canvas.DrawString("Value 1.2", font, brush, 40, 40)

        ' Add another independent group of radio buttons
        Dim radioButton3 = New RadioButton(120, 20, 15, 15, "group2", "value3")
        Dim radioButton4 = New RadioButton(120, 40, 15, 15, "group2", "value4")
        page.Annotations.Add(radioButton3)
        page.Annotations.Add(radioButton4)
        ' Add labels
        page.Canvas.DrawString("Value 2.1", font, brush, 140, 20)
        page.Canvas.DrawString("Value 2.2", font, brush, 140, 40)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
