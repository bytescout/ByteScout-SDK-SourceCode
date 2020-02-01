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
''' This example demonstrates how to save and restore the graphics state.
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

        Dim canvas = page.Canvas

        ' Keep current graphics state
        canvas.SaveGraphicsState()

        ' Transform coordinates and draw rectangle
        canvas.TranslateTransform(200, 200)
        canvas.RotateTransform(45)
        canvas.DrawRectangle(New SolidBrush(New ColorRGB(0, 0, 255)), 0, 0, 100, 100)

        ' Restore the state and draw the same rectangle
        canvas.RestoreGraphicsState()
        canvas.DrawRectangle(New SolidBrush(New ColorRGB(255, 0, 0)), 200, 200, 100, 100)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
