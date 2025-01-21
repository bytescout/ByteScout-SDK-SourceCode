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
Imports Bytescout.PDF
Imports Bytescout.PDFExtractor

Module Module1

    Sub Main()

        Dim inputFile As String = ".\sample.pdf"
        Dim pageIndex As Integer = 0
        Dim searchPattern As String = "\d+\.\d+"

        ' Prepare TextExtractor
        Using textExtractor As TextExtractor = New TextExtractor("demo", "demo")

            textExtractor.RegexSearch = true
            textExtractor.LoadDocumentFromFile(inputFile)

            ' Load document with PDF SDK
            Using pdfDocument As Document = New Document(inputFile)

                pdfDocument.RegistrationName = "demo"
                pdfDocument.RegistrationKey = "demo"

                Dim pdfDocumentPage As Page = pdfDocument.Pages(pageIndex)
                Dim canvas As Canvas = pdfDocumentPage.Canvas

                Dim fillBrush As Bytescout.PDF.SolidBrush = new Bytescout.PDF.SolidBrush(new ColorRGB(255, 0, 0))
                fillBrush.Opacity = 50 ' make the brush transparent

                ' Search for pattern and highlight found pieces
                If textExtractor.Find(pageIndex, searchPattern, caseSensitive := False)

                    Do
                        For Each foundPiece In textExtractor.FoundText.Elements
                            
                            ' Inflate the rectangle a bit
                            Dim rect As RectangleF = RectangleF.Inflate(foundPiece.Bounds, 1, 2)
                            ' Draw rectangle over the PDF page
                            canvas.DrawRectangle(fillBrush, rect)

                        Next

                    Loop While textExtractor.FindNext()

                End If

                ' Save as new PDF document
                pdfDocument.Save("result.pdf")

                ' Open result document in default associated application (for demo purposes)
                Process.Start("result.pdf")
                
            End Using

        End Using

    End Sub

End Module
