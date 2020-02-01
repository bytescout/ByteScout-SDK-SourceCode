'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to create PDF from multipage TIFF image. 
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
        pdfDocument.RegistrationKey = "demo"

        ' Get TIFF file in BitMap
        Dim multipageTiffImage As Bitmap = Drawing.Image.FromFile("MultipageTiffFile.tiff")

        ' Tiff images can contain multiple images named as frame
        Dim count = multipageTiffImage.GetFrameCount(FrameDimension.Page)

        For idx = 0 To count - 1

            ' Save each frame to a bytestream
            multipageTiffImage.SelectActiveFrame(FrameDimension.Page, idx)

            Dim byteStream As New MemoryStream()
            multipageTiffImage.Save(byteStream, ImageFormat.Tiff)

            Dim sysImage = FixImageOrientation(byteStream)

            Using sysImage

                Dim image = New Bytescout.PDF.Image(sysImage, ImageCompression.DCT, 75)
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

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

    ''' <summary>
    ''' Fix image orientation
    ''' </summary>
    Private Shared Function FixImageOrientation(ByVal fileStream As Stream) As System.Drawing.Image

        Dim sysImage As System.Drawing.Image = System.Drawing.Image.FromStream(fileStream, False, False)

        ' fix orientation by EXIF rotation tag
        Const exifRotationTag As Integer = &H112
        Dim propertyItemIDs As Integer() = sysImage.PropertyIdList

        Dim found As Integer = Array.BinarySearch(propertyItemIDs, 0, propertyItemIDs.Length, exifRotationTag)

        If found > -1 Then
            Dim pi As PropertyItem = sysImage.GetPropertyItem(exifRotationTag)
            Dim orientation As Integer = pi.Value(0)

            Select Case orientation
                Case 2
                    sysImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
                Case 3
                    sysImage.RotateFlip(RotateFlipType.Rotate180FlipNone)
                Case 4
                    sysImage.RotateFlip(RotateFlipType.RotateNoneFlipY)
                Case 5
                    sysImage.RotateFlip(RotateFlipType.Rotate90FlipX)
                Case 6
                    sysImage.RotateFlip(RotateFlipType.Rotate90FlipNone)
                Case 7
                    sysImage.RotateFlip(RotateFlipType.Rotate270FlipX)
                Case 8
                    sysImage.RotateFlip(RotateFlipType.Rotate270FlipNone)
                Case Else
            End Select

            sysImage.RemovePropertyItem(&H112)
        End If

        Return sysImage
    End Function


End Class
