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
            Process.Start(outputFile)

        End Sub

    End Class

End Namespace

