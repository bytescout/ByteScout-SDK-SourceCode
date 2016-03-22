'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to draw transparent objects.
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

        Dim canvas = page.Canvas

        ' Prepare pens and brushes
        Dim borderPen = New SolidPen(New ColorRGB(0, 0, 0), 2.0F)

        Dim brush1 = New SolidBrush(New ColorRGB(255, 0, 0))
        Dim brush2 = New SolidBrush(New ColorRGB(0, 0, 255))

        borderPen.Opacity = 50
        brush1.Opacity = 30
        brush2.Opacity = 60

        ' Draw normal rectangles
        canvas.DrawRectangle(brush1, 100, 100, 100, 100)
        canvas.DrawRectangle(borderPen, brush2, 150, 150, 100, 100)

        borderPen.Opacity = 80
        brush1.Opacity = 60
        brush2.Opacity = 30

        ' Draw rounded rectangles
        canvas.DrawRoundedRectangle(brush1, 220, 100, 100, 100, 10)
        canvas.DrawRoundedRectangle(borderPen, brush2, 270, 150, 100, 100, 10)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
