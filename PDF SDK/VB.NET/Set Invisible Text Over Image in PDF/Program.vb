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
''' This example demonstrates how to create PDF document from scanned document image and add invisible text over it. 
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new PDF document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
        pdfDocument.RegistrationKey = "demo"

        ' If you wish to load an existing document uncomment the line below And comment the Add page section instead
        ' pdfDocument.Load(".\existing_document.pdf")

        ' Load image from file to System.Drawing.Image object (we need it to get the image resolution)
        Dim sysImage As System.Drawing.Image = System.Drawing.Image.FromFile(".\scanned-invoice.png")
        ' Compute image size in PDF units (Points)
        Dim widthInPoints As Single = sysImage.Width / sysImage.HorizontalResolution * 72.0F
        Dim heightInPoints As Single = sysImage.Height / sysImage.VerticalResolution * 72.0F

        ' Create page of computed size
        Dim page = New Page(widthInPoints, heightInPoints)
        ' Add page to the document
        pdfDocument.Pages.Add(page)

        Dim canvas = page.Canvas

        ' Create Bytescout.PDF.Image object from loaded image
        Dim pdfImage = New Image(sysImage)
        ' Draw the image
        canvas.DrawImage(pdfImage, 0, 0, widthInPoints, heightInPoints)

        ' Dispose the System.Drawing.Image object to free resources
        sysImage.Dispose()

        ' Create brush
        Dim transparentBrush As SolidBrush = New SolidBrush(New ColorGray(0))
        ' ... and make it transparent
        transparentBrush.Opacity = 0

        ' Draw text with transparent brush
        Dim font16 As Font = New Font(StandardFonts.Helvetica, 16)
        canvas.DrawString("Your Company Name", font16, transparentBrush, 40, 40)

        ' Draw another text
        Dim font10 As Font = New Font(StandardFonts.Helvetica, 10)
        canvas.DrawString("Your Address", font10, transparentBrush, 40, 80)


        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
