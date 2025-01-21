'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing
Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to draw rectangles.
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

        ' Prepare pens and brushes
        Dim borderPen = New SolidPen(New ColorGray(128), 2.0F)
        Dim brush1 = New Bytescout.PDF.SolidBrush(New ColorRGB(255, 0, 0))
        Dim brush2 = New Bytescout.PDF.SolidBrush(New ColorRGB(0, 255, 255))

        ' Draw transparent rectangle with border only
        canvas.DrawRectangle(borderPen, 100, 100, 100, 50)

        ' Draw rounded rectangle with broder and filling
        canvas.DrawRoundedRectangle(borderPen, brush1, 250, 100, 100, 50, 10)

        ' Draw rectangle as polygon
        canvas.DrawPolygon(borderPen, brush2, New PointF() {New PointF(400, 100), New PointF(500, 100), New PointF(500, 150), New PointF(400, 150)})

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
