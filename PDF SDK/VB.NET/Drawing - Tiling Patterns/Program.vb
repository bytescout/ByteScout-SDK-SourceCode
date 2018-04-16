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


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to use tiling patterns.
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

        Dim blueColor = New ColorRGB(0, 0, 255)
        Dim grayColor = New ColorRGB(128, 128, 128)

        ' Create tiling brush and paint on it 
        Dim tilingBrush1 = New UncoloredTilingBrush(10, 12)
        Dim brushCanvas = tilingBrush1.Canvas
        brushCanvas.DrawCircle(New SolidPen(blueColor), 0, 6, 6)
        tilingBrush1.Color = blueColor

        ' Create second tiling brush and paint on it using the first brush
        Dim tilingBrush2 = New ColoredTilingBrush(70, 50)
        brushCanvas = tilingBrush2.Canvas
        brushCanvas.DrawEllipse(New SolidPen(grayColor), tilingBrush1, 0, 0, 60, 20)

        ' Draw rectangle and fill it with combined tiling brush
        page.Canvas.DrawRectangle(New SolidPen(), tilingBrush2, 100, 100, 400, 400)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
