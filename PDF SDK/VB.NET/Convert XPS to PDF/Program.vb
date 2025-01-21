'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing.Imaging
Imports System.IO
Imports Bytescout.PDF
Imports xps2img

Imports Page = Bytescout.PDF.Page

''' <summary>
''' This example demonstrates converting xps document to pdf 
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
        pdfDocument.RegistrationKey = "demo"

        ' If you wish to load an existing document uncomment the line below And comment the Add page section instead
        ' pdfDocument.Load(".\existing_document.pdf")

        'Create instance And load file
        Dim xps2Image As New Xps2Image("Sample.xps")

        ' Set parameter
        Dim oParam As New Parameters()
        oParam.Dpi = 300 ' Set Dpi
        oParam.ImageType = ImageType.Png ' Output image type

        ' Get Bitmap from input file
        Dim outBitmapList = xps2Image.ToBitmap(oParam)

        For Each itmBitmap In outBitmapList

            ' Create New pdf page
            Dim page As New Page(PaperFormat.A4)

            ' Save image to a bytestream
            Dim byteStream As New MemoryStream()
            itmBitmap.Save(byteStream, ImageFormat.Png)

            ' Fill page with image
            Dim pageImage As New Image(byteStream)
            page.Canvas.DrawImage(pageImage, 5, 5, pageImage.Width / 2, pageImage.Height / 3)

            ' Add pdf page to pdf document
            pdfDocument.Pages.Add(page)

        Next

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open result document in default associated application (for demo purpose)
        Dim processStartInfo As New ProcessStartInfo("result.pdf")
        processStartInfo.UseShellExecute = True
        Process.Start(processStartInfo)

    End Sub

End Class
