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
''' This example demonstrates how to create a listbox.
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

        ' Add list box, add items and make it multi-selectable
        Dim listBox1 = New ListBox(20, 20, 120, 80, "listBox1")
        listBox1.Items.Add("Value 1")
        listBox1.Items.Add("Value 2")
        listBox1.Items.Add("Value 3")
        listBox1.Items.Add("Value 4")
        listBox1.Items.Add("Value 5")
        listBox1.MultiSelect = True
        ' Decorate listbox
        listBox1.Font = New Font(StandardFonts.Helvetica, 10)
        listBox1.FontColor = New ColorRGB(0, 0, 128)
        listBox1.BorderColor = New ColorRGB(0, 0, 128)
        listBox1.BackgroundColor = New ColorRGB(240, 240, 255)
        listBox1.BorderWidth = 2

        page.Annotations.Add(listBox1)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
