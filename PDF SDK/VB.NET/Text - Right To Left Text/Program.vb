'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to draw right-to-left text.
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

        Dim font = New Font("Arial", 16)
        Dim brush = New SolidBrush()

        ' Set right to left text direction
        Dim stringFormat = New StringFormat()
        stringFormat.DirectionRightToLeft = True

        page.Canvas.DrawString("واحد اثنين ثلاثة", font, brush, page.Width - 20, 30, stringFormat)
        page.Canvas.DrawString("אחת, שתיים, שלוש", font, brush, page.Width - 20, 50, stringFormat)
        page.Canvas.DrawString("یک دو سه", font, brush, page.Width - 20, 70, stringFormat)


        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
