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


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how add text watermark to document page.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        ' If you wish to load an existing document uncomment the line below And comment the Add page section instead
        ' pdfDocument.Load(".\existing_document.pdf")

        ' Add pages
        pdfDocument.Pages.Add(New Page(PaperFormat.A4))
        pdfDocument.Pages.Add(New Page(PaperFormat.A4))
        pdfDocument.Pages.Add(New Page(PaperFormat.A4))

        ' Add tiling watermark
        Dim watermark1 = New TextWatermark("Tiling Watermark")
        watermark1.WatermarkLocation = TextWatermarkLocation.Tiled
        watermark1.Angle = 30
        Dim brush1 = New SolidBrush(New ColorRGB(0, 0, 255))
        brush1.Opacity = 50 ' make the brush semitransparent
        watermark1.Brush = brush1
        pdfDocument.Watermarks.Add(watermark1)

        ' Add autosized watermark to every page of the document
        Dim watermark2 = New TextWatermark("Diagonal Watermark")
        watermark2.WatermarkLocation = TextWatermarkLocation.DiagonalFromBottomLeftToTopRight
        watermark2.Font = New Font("Times New Roman", 16)
        Dim brush2 = New SolidBrush(New ColorRGB(255, 0, 0))
        brush2.Opacity = 50 ' make the brush semitransparent
        watermark2.Brush = brush2
        watermark2.Pen = New SolidPen(New ColorRGB(255, 0, 0)) ' outline pen is optional
        pdfDocument.Watermarks.Add(watermark2)

        ' Add watermark of custom size and location to the first page only
        Dim watermark3 = New TextWatermark("Simple Watermark")
        watermark3.Font = New Font(StandardFonts.HelveticaBold, 24)
        watermark3.Brush = New SolidBrush(New ColorRGB(0, 128, 0))
        watermark3.Left = 350
        watermark3.Top = 800
        pdfDocument.Pages(0).Watermarks.Add(watermark3)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
