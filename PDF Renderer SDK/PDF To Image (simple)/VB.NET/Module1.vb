'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDFRenderer

Module Module1

    Sub Main()

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
        Dim renderer As RasterRenderer = New RasterRenderer("demo", "demo")
        renderer.RegistrationName = "demo"
        renderer.RegistrationKey = "demo"

        ' Load PDF document.
        renderer.LoadDocumentFromFile("multipage.pdf")

        ' Render first page of the document to PNG image file.
        renderer.RenderPageToFile(0, RasterOutputFormat.PNG, "result.png")

        ' Open the output file in default image viewer.
        Process.Start("result.png")

    End Sub

End Module
