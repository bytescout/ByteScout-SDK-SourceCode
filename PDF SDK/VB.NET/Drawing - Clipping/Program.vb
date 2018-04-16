'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports System.Drawing
Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to use the graphics clipping.
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
        
        Dim center = New PointF(200, 200)

        ' Create clipping path from circle
        Dim path = New Path()
        path.AddCircle(center, 100)
        page.Canvas.SetClip(path)

        ' Paint Bytescout.PDF.Rectangle over the clipping circle.
        ' Only part of the Bytescout.PDF.Rectangle intersecting the clipping circle will be drawn.
        Dim brush = New Bytescout.PDF.SolidBrush(New ColorRGB(255, 0, 0))
        page.Canvas.DrawRectangle(brush, center.X - 50, center.Y - 50, 200, 200)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
