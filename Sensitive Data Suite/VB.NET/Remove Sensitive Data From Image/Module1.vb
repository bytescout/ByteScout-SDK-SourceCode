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


Imports System.IO
Imports System.Drawing
Imports Bytescout.PDFExtractor

Class Program

    Shared Sub Main(ByVal args As String())

        Dim input As String = "scanned_sample_EmailSSN.png"
        Dim result As String = "result.png"

        Using detector As New SensitiveDataDetector("demo", "demo")

            ' Enable OCR mode And provide path to data folder
            detector.OCRMode = OCRMode.Auto
            detector.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

            detector.LoadDocumentFromFile(input)

            ' Detect sensitive data
            Dim detectionResults As SensitiveDataDetectionResults = detector.PerformDetection()

            If detectionResults.DetectedItems.Length > 0 Then

                Using image As Image = Image.FromFile(input)

                    ' Create new bitmap, as graphics object require indexed pixel format 
                    Using newBitmap As New Bitmap(image.Width, image.Height)

                        Using g As Graphics = Graphics.FromImage(newBitmap)

                            g.DrawImage(image, 0, 0)

                            For Each detectedItem As DetectedSensitiveItem In detectionResults.DetectedItems

                                ' Convert coordinates from Points (1/72") to display pixels

                                Dim rect As Rectangle = New Rectangle(
                                        CInt(detectedItem.Rectangle.X * 96 / 72),
                                        CInt(detectedItem.Rectangle.Y * 96 / 72),
                                        CInt(detectedItem.Rectangle.Width * 96 / 72),
                                        CInt(detectedItem.Rectangle.Height * 96 / 72))

                                ' Paint over the detected item with a white Or black brush
                                g.FillRectangle(Brushes.Black, rect)

                            Next

                        End Using

                        newBitmap.Save(result)

                    End Using

                End Using

            End If

        End Using

        ' Open output file with attached application
        Dim processStartInfo As New ProcessStartInfo(result)
        processStartInfo.UseShellExecute = True
        Process.Start(processStartInfo)

    End Sub

End Class
