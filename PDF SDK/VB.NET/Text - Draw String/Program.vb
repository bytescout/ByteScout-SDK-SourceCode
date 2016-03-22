'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Drawing
Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to draw a text.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        ' Add page
        Dim page = New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page)

        ' Draw simple text
        Dim font = New Bytescout.PDF.Font("Arial", 24)
        Dim blackBrush = New Bytescout.PDF.SolidBrush()
        page.Canvas.DrawString("Simple text.", font, blackBrush, 20, 20)

        ' Draw text with alignment in specified rectangle
        Dim stringFormat = New Bytescout.PDF.StringFormat()
        stringFormat.HorizontalAlign = HorizontalAlign.Right
        stringFormat.VerticalAlign = VerticalAlign.Bottom
        page.Canvas.DrawString("Aligned text", font, blackBrush, New RectangleF(20, 100, 200, 60), stringFormat)
        page.Canvas.DrawRectangle(New SolidPen(), 20, 100, 200, 60)

        ' Draw colored text
        Dim boldFont = New Bytescout.PDF.Font("Arial", 32, True, False, False, False)
        Dim redBrush = New Bytescout.PDF.SolidBrush(New ColorRGB(255, 0, 0))
        Dim bluePen = New SolidPen(New ColorRGB(0, 0, 255))
        page.Canvas.DrawString("Colored text", boldFont, redBrush, 20, 200)
        page.Canvas.DrawString("Outlined colored text", boldFont, redBrush, bluePen, 20, 240)
        page.Canvas.DrawString("Outlined transparent text", boldFont, bluePen, 20, 280)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
