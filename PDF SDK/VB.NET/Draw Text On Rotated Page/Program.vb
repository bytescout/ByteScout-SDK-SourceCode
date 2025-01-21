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
Imports Font = Bytescout.PDF.Font
Imports SolidBrush = Bytescout.PDF.SolidBrush
Imports StringFormat = Bytescout.PDF.StringFormat

''' <summary>
''' This example demonstrates how to add header and footer to rotated PDF pages.
''' </summary>
Class Program

    Shared Sub Main()

        ' Load PDF form
        Dim pdfDocument = New Document("RotatedPages.pdf")
        pdfDocument.RegistrationName = "demo"
        pdfDocument.RegistrationKey = "demo"

        Dim headerText As String = "Sample Header"
        Dim footerText As String = "Sample Footer"

        ' Prepare StringFormat with Center text alignment
        Dim stringFormat As New StringFormat() With {.HorizontalAlign = HorizontalAlign.Center}

        ' Prepare drawing tools
        Dim font As New Font(standardFont:=StandardFonts.Helvetica, emSize:=9)
        Dim brush As New SolidBrush(New ColorRGB(255, 0, 0))

        For i As Integer = 0 To pdfDocument.Pages.Count - 1

            Dim page As Page = pdfDocument.Pages(i)

            page.Canvas.SaveGraphicsState()

            ' Calculate the coordinates of the text taking into account the page rotation:
            Dim headerY As Single = 10
            Dim footerY As Single
            Dim textRectWidth As Single
            Dim textRectHeight As Single = font.GetTextHeight() + 5

            If page.RotationAngle = RotationAngle.Rotate0 Or page.RotationAngle = RotationAngle.Rotate180 Then
                footerY = page.Height - textRectHeight - 10
                textRectWidth = page.Width
            Else
                footerY = page.Width - textRectHeight - 10
                textRectWidth = page.Height
            End If

            ' Rotate page canvas according to page rotation
            Select Case page.RotationAngle

                Case RotationAngle.Rotate90
                    page.Canvas.RotateTransform(-90)
                    page.Canvas.TranslateTransform(-page.Height, 0)
                    Exit Select

                Case RotationAngle.Rotate180
                    page.Canvas.RotateTransform(180)
                    page.Canvas.TranslateTransform(-page.Width, -page.Height)
                    Exit Select

                Case RotationAngle.Rotate270
                    page.Canvas.RotateTransform(-270)
                    page.Canvas.TranslateTransform(0, -page.Width)
                    Exit Select

            End Select

            ' Draw header And footer
            page.Canvas.DrawString(headerText, font, brush, New RectangleF(0, headerY, textRectWidth, textRectHeight), stringFormat)
            page.Canvas.DrawString(footerText, font, brush, New RectangleF(0, footerY, textRectWidth, textRectHeight), stringFormat)

            page.Canvas.RestoreGraphicsState()

        Next

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
