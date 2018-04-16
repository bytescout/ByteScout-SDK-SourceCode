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
''' This example demonstrates how to add layers with optional content.
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

        ' Add main layer
        Dim allContents = New Layer("Main Layer")
        canvas.BeginMarkedContent(allContents)

        ' Add sub-layer
        Dim layer1 = New Layer("Square")
        canvas.BeginMarkedContent(layer1)
        canvas.DrawRectangle(New Bytescout.PDF.SolidBrush(New ColorRGB(0, 255, 0)), 20, 20, 100, 100)
        canvas.EndMarkedContent()

        ' Add second sub-layer
        Dim layer2 = New Layer("Circle")
        canvas.BeginMarkedContent(layer2)
        canvas.DrawCircle(New Bytescout.PDF.SolidBrush(New ColorRGB(255, 0, 0)), 70, 180, 50)
        canvas.EndMarkedContent()

        ' Add third sub-layer
        Dim layer3 = New Layer("Triangle")
        canvas.BeginMarkedContent(layer3)
        canvas.DrawPolygon(New Bytescout.PDF.SolidBrush(New ColorRGB(0, 0, 255)), New PointF() {New PointF(20, 340), New PointF(70, 240), New PointF(120, 340)})
        canvas.EndMarkedContent()

        canvas.EndMarkedContent()

        pdfDocument.OptionalContents.Layers.Add(layer1)
        pdfDocument.OptionalContents.Layers.Add(layer2)
        pdfDocument.OptionalContents.Layers.Add(layer3)
        pdfDocument.OptionalContents.Layers.Add(allContents)

        ' Configure layers

        ' Group sub-layers
        Dim group = New OptionalContentGroup()
        group.Add(New OptionalContentGroupLayer(layer1))
        group.Add(New OptionalContentGroupLayer(layer2))
        group.Add(New OptionalContentGroupLayer(layer3))

        ' Order sub-layers
        pdfDocument.OptionalContents.Configuration.Order.Add(New OptionalContentGroupLayer(allContents))
        pdfDocument.OptionalContents.Configuration.Order.Add(group)

        ' Make the third layer invisible by default (for example)
        pdfDocument.OptionalContents.Configuration.OFF.Add(layer3)

        ' Force the PDF viewer to show the layers panel initially
        pdfDocument.PageMode = PageMode.OptionalContent

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
