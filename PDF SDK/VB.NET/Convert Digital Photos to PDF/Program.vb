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
''' This example demonstrates how to add images in their proper orientation and size
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument As Document = New Document()
        pdfDocument.RegistrationName = "demo"
        pdfDocument.RegistrationKey = "demo"

        ' If you wish to load an existing document uncomment the line below And comment the Add page section instead
        ' pdfDocument.Load(".\existing_document.pdf")

        ' Input image array
        Dim arrImages = New String() {"Image1.jpg", "Image2.jpg"}

        ' Process each image
        For Each itmImage In arrImages

            Dim sysImage = FixImageOrientation(itmImage)

            Using sysImage

                Dim image = New Image(sysImage, ImageCompression.DCT, 75)
                Dim w As Single = sysImage.Width / sysImage.HorizontalResolution * 72.0F
                Dim h As Single = sysImage.Height / sysImage.VerticalResolution * 72.0F

                ' Create PDF page
                Dim page = New Page(w, h)

                Dim canvas = page.Canvas
                canvas.DrawImage(image, 0, 0, w, h)

                ' Add PDF document
                pdfDocument.Pages.Add(page)

            End Using
        Next

        ' Save PDF document
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open result document in default associated application (for demo purpose)
        Dim processStartInfo As ProcessStartInfo = New ProcessStartInfo("result.pdf")
        processStartInfo.UseShellExecute = True
        Process.Start(processStartInfo)

    End Sub

    ''' <summary>
    ''' Fix image orientation
    ''' </summary>
    Private Shared Function FixImageOrientation(ByVal fileName As String) As System.Drawing.Image

        Dim sysImage As System.Drawing.Image = System.Drawing.Image.FromFile(fileName, False)

        ' fix orientation by EXIF rotation tag
        Const exifRotationTag As Integer = &H112
        Dim propertyItemIDs As Integer() = sysImage.PropertyIdList

        Dim found As Integer = Array.BinarySearch(propertyItemIDs, 0, propertyItemIDs.Length, exifRotationTag)

        If found > -1 Then
            Dim pi As System.Drawing.Imaging.PropertyItem = sysImage.GetPropertyItem(exifRotationTag)
            Dim orientation As Integer = pi.Value(0)

            Select Case orientation
                Case 2
                    sysImage.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipX)
                Case 3
                    sysImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone)
                Case 4
                    sysImage.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipY)
                Case 5
                    sysImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipX)
                Case 6
                    sysImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone)
                Case 7
                    sysImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipX)
                Case 8
                    sysImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone)
                Case Else
            End Select

            sysImage.RemovePropertyItem(&H112)
        End If

        Return sysImage
    End Function

End Class
