'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


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

        ' Get size of the page in Points (standard PDF document units; 1 Point = 1/72")
        Dim rectangle As RectangleF = renderer.GetPageRectangle(0)

        Dim width, height As Integer

        If rectangle.Width < rectangle.Height Then ' portrait page orientation

            width = -1 ' width will be calculated from height keeping the aspect ratio
            height = 100

        Else ' landscape page orientation

            width = 100
            height = -1	' height will be calculated from width keeping the aspect ratio

        End If

        ' Render first page of the document to JPEG image file
        renderer.Save("thumbnail.jpg", RasterImageFormat.JPEG, 0, width, height)

        ' Cleanup
        renderer.Dispose()

        ' Open the output image file in default image viewer
        System.Diagnostics.Process.Start("thumbnail.jpg")

    End Sub

End Module
