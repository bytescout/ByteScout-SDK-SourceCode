'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


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
