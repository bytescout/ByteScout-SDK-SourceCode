'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
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
