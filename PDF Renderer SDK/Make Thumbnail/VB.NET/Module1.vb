'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Drawing
Imports Bytescout.PDFRenderer

Module Module1

    Sub Main()

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
        Dim renderer As New RasterRenderer()
        renderer.RegistrationName = "demo"
        renderer.RegistrationKey = "demo"

        ' Load PDF document
        renderer.LoadDocumentFromFile("multipage.pdf")

        ' Size of the page in Points (standart PDF document units; 1 Point = 1/72")
        Dim rectangle As RectangleF = renderer.GetPageRectangle(0)

        If rectangle.Width < rectangle.Height Then ' portrait page orientation

            ' Calculate rendering resoultion to get an image of 100px width
            renderer.Resolution = 100 / rectangle.Width * 72

        Else ' landscape page orientation

            ' Calculate rendering resoultion to get an image of 100px height
            renderer.Resolution = 100 / rectangle.Height * 72

        End If

        ' Render first page of the document to JPEG image file
        renderer.RenderPageToFile(0, RasterOutputFormat.JPEG, "thumbnail.jpg")

        ' Open the output image file in default image viewer
        System.Diagnostics.Process.Start("thumbnail.jpg")

    End Sub

End Module
