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
''' This example demonstrates how to create a document and save it to file.
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
        Dim stringFormat = New StringFormat()
        Dim xPosition As Single = 20

        ' Draw normal string
        page.Canvas.DrawString("Normal text ", font, brush, xPosition, 50, stringFormat)
        xPosition += font.GetTextWidth("Normal text ")

        ' Draw subscript string 
        stringFormat.Rise = -5
        page.Canvas.DrawString("Subscript", font, brush, xPosition, 50, stringFormat)
        xPosition += font.GetTextWidth("Subscript")

        ' draw superscript string
        stringFormat.Rise = +5
        page.Canvas.DrawString("Superscript", font, brush, xPosition, 50, stringFormat)
        xPosition += font.GetTextWidth("Superscript")

        ' Draw the baseline
        Dim pen = New SolidPen(New ColorRGB(0, 0, 255))
        pen.Opacity = 50
        page.Canvas.DrawLine(pen, 20, 50 + font.Size, xPosition, 50 + font.Size)


        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
