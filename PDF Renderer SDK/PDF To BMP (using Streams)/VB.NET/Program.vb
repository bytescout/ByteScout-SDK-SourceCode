'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************


Imports Bytescout.PDFRenderer
Imports System.IO


Class Program
	Friend Shared Sub Main(args As String())

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.

        Dim pdf_stream As FileStream
        pdf_stream = New FileStream("multipage.pdf", FileMode.Open)

        Dim renderer As RasterRenderer
        renderer = New RasterRenderer("demo", "demo")
        Using renderer
            ' Load PDF document.
            renderer.LoadDocumentFromStream(pdf_stream)
            For i As Integer = 0 To renderer.GetPageCount() - 1
                ' Render first page of the document to PNG image file.
                If File.Exists("output" + i.ToString() + ".bmp") Then
                    File.Delete("output" + i.ToString() + ".bmp")
                End If
                Using mstrm As New FileStream("output" + i.ToString() + ".bmp", FileMode.CreateNew)
                    renderer.RenderPageToStream(i, RasterOutputFormat.BMP, mstrm)
                    ' img_slider_patrec_img.Images.Add(Image.FromStream(mstrm))
                End Using
            Next
            ' .Show("Loaded " & renderer.GetPageCount() & " Page(s) - Please Save to Store With Record", "Finished Loading Pages", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Using

    End Sub
End Class
