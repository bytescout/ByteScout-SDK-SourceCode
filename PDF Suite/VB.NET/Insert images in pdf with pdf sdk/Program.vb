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
''' This example demonstrates how to add images of various formats. 
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

        ' Add JPEG image and draw unscaled
        Dim image1 = New Image("Image1.jpg")
        canvas.DrawImage(image1, 20, 20)

        ' Add PNG image and draw reduced twice
        Dim image2 = New Image("Image2.png")
        canvas.DrawImage(image2, 20, 520, image2.Width / 2, image2.Height / 2)

        ' Add TIFF image and draw scaled disproportionately
        Dim image3 = New Image("Image3.tif")
        canvas.DrawImage(image3, 270, 520, image3.Width / 2, image3.Height / 4)

        ' Add GIF image and draw rotated 90 degrees and scaled
        Dim image4 = New Image("Image4.gif")
        canvas.TranslateTransform(390, 650)
        canvas.RotateTransform(90)
        canvas.DrawImage(image4, 0, 0, image4.Width / 4, image4.Height / 4)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
