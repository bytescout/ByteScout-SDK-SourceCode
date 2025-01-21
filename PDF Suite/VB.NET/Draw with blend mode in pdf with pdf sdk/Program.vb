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
''' This example demonstrates how to use blend modes - a way how 
''' intersecting semi-transparent objects will blend on page canvas.
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

        ' Create transparent brushes
        Dim brushRed = New SolidBrush(New ColorRGB(255, 0, 0))
        brushRed.Opacity = 50
        Dim brushGreen = New SolidBrush(New ColorRGB(0, 255, 0))
        brushGreen.Opacity = 50
        Dim brushBlue = New SolidBrush(New ColorRGB(0, 0, 255))
        brushBlue.Opacity = 50

        ' Normal blending
        canvas.BlendMode = BlendMode.Normal
        canvas.DrawCircle(brushRed, 100, 100, 50)
        canvas.DrawCircle(brushGreen, 100, 150, 50)
        canvas.DrawCircle(brushBlue, 150, 100, 50)

        ' Darken blending
        canvas.BlendMode = BlendMode.Darken
        canvas.DrawCircle(brushRed, 300, 100, 50)
        canvas.DrawCircle(brushGreen, 300, 150, 50)
        canvas.DrawCircle(brushBlue, 350, 100, 50)

        ' Lighten blending
        canvas.BlendMode = BlendMode.Lighten
        canvas.DrawCircle(brushRed, 100, 300, 50)
        canvas.DrawCircle(brushGreen, 100, 350, 50)
        canvas.DrawCircle(brushBlue, 150, 300, 50)

        ' Color burn blending
        canvas.BlendMode = BlendMode.ColorBurn
        canvas.DrawCircle(brushRed, 300, 300, 50)
        canvas.DrawCircle(brushGreen, 300, 350, 50)
        canvas.DrawCircle(brushBlue, 350, 300, 50)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
