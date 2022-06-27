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
Imports Bytescout.PDF
Imports Font = Bytescout.PDF.Font
Imports SolidBrush = Bytescout.PDF.SolidBrush
Imports StringFormat = Bytescout.PDF.StringFormat

''' <summary>
''' This example demonstrates how to draw invisible text.
''' </summary>
Class Program

    Shared Sub Main()

        ' Sample input text chunks
        Dim textChunks As List(Of TextChunk) = New List(Of TextChunk)() From {
            New TextChunk("Test Document for Optical Character Recognition (OCR)", New RectangleF(178.08F, 81.12F, 235.92F, 6.96F)),
            New TextChunk("Test Document for Optical Character Recognition (OCR)", New RectangleF(178.08F, 103.44F, 235.92F, 6.96F))
        }

        ' Load document
        Dim pdfDocument = New Document(".\sample_scanned.pdf")
        pdfDocument.RegistrationName = "demo"
        pdfDocument.RegistrationKey = "demo"

        For i As Integer = 0 To pdfDocument.Pages.Count - 1
            DrawTransparentText(pdfDocument.Pages(i), textChunks, "Times", 7.0F)
        Next

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup
        pdfDocument.Dispose()

    End Sub

    Private Shared Sub DrawTransparentText(ByVal documentPage As Page, ByVal textChunks As List(Of TextChunk), ByVal Optional fontName As String = "Arial", ByVal Optional maxFontSize As Single = 4.0F)
        Dim stringFormat = New StringFormat()
        Dim transparentBrush = New SolidBrush With {.Opacity = 0}

        For Each textChunk In textChunks
            Dim font As Font = New Font(fontName, Math.Max(textChunk.Rect.Height, maxFontSize))

            ' Fit drawn text into chunk rectangle
            Dim renderedWidth As Single = font.GetTextWidth(textChunk.Text)
            stringFormat.Scaling = textChunk.Rect.Width / renderedWidth * 100

            documentPage.Canvas.DrawString(textChunk.Text, font, transparentBrush, textChunk.Rect.Left, textChunk.Rect.Top, stringFormat)
        Next
    End Sub

End Class

Class TextChunk
    Public Property Text As String
    Public Property Rect As RectangleF

    Public Sub New(ByVal text As String, ByVal rect As RectangleF)
        Me.Text = text
        Me.Rect = rect
    End Sub
End Class
