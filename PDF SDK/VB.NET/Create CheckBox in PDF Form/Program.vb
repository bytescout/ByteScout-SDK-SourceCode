'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
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
