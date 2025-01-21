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
''' This example demonstrates how to use coordinate space transformations.
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

        ' Prepare pens
        Dim blackPen = New SolidPen(New ColorRGB(0, 0, 0), 2.0F)
        blackPen.Opacity = 50
        Dim bluePen = New SolidPen(New ColorRGB(0, 0, 255), 2.0F)
        bluePen.Opacity = 50
        Dim greenPen = New SolidPen(New ColorRGB(0, 255, 0), 2.0F)
        greenPen.Opacity = 50

        ' Move coordinate space zero point to (200, 200) and draw a rectangle of 50x50 dize
        canvas.TranslateTransform(200, 200)
        canvas.DrawRectangle(blackPen, 0, 0, 50, 50)

        ' Now zoom the coordinate space in twice and draw the same rectangle in green
        canvas.ScaleTransform(2, 2)
        canvas.DrawRectangle(greenPen, 0, 0, 50, 50)

        ' Now rotate the coordinate space by 30 degrees and draw the same rectangle in blue
        canvas.RotateTransform(30)
        canvas.DrawRectangle(bluePen, 0, 0, 50, 50)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
