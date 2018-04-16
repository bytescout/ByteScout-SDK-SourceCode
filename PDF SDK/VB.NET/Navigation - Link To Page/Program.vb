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


Imports System.Drawing
Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to create a navigation link to a page.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        ' Add two pages
        Dim page1 = New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page1)
        Dim page2 = New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page2)

        Dim font = New Bytescout.PDF.Font(StandardFonts.Times, 12)
        Dim brush = New Bytescout.PDF.SolidBrush()

        ' Create link annotation pointing to Page 2, 200 Points from the top.
        Dim destination = New Destination(page2, 200)
        Dim link = New LinkAnnotation(destination, 20, 20, 100, 25)
        link.Color = New ColorRGB(255, 0, 0) ' you can change the link color
        page1.Annotations.Add(link)

        ' Draw link text (optional)
        page1.Canvas.DrawString("Link to Page 2", font, brush, New RectangleF(20, 20, 100, 25),
            New Bytescout.PDF.StringFormat() With {.HorizontalAlign = HorizontalAlign.Center, .VerticalAlign = VerticalAlign.Center})

        ' Draw a text at the link target
        page2.Canvas.DrawString("Link target", font, brush, 20, 200)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
