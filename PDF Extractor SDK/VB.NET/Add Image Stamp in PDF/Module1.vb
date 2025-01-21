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
Imports Bytescout.PDFExtractor

Namespace AddImageStampInPDF

    Class Program

        Shared Sub Main(ByVal args As String())

            Dim inputFile As String = ".\Invoice.pdf"
            Dim outputFile As String = ".\Invoice_Stamped.pdf"
            Dim stampImageFile As String = ".\stamp_image.png"

            Using stamper As New Stamper("demo", "demo")

                ' Optionally make the image background transparent
                ' stamper.MakeStampImageTransparent = true

                Using image As Image = Image.FromFile(stampImageFile)

                    ' Get image size in PDF units
                    Dim imageSizeInPoints As SizeF = stamper.GetImageSizeInPoints(image)

                    Dim Rectangle = New RectangleF(440, 370, imageSizeInPoints.Width / 3, imageSizeInPoints.Height / 3)

                    stamper.Stamp(inputFile, outputFile, image, Rectangle, 0, -1)

                End Using

            End Using

            ' Open result file in default associated application (for demo purposes)
            Dim processStartInfo As New ProcessStartInfo(outputFile)
            processStartInfo.UseShellExecute = True
            Process.Start(processStartInfo)

        End Sub

    End Class

End Namespace

