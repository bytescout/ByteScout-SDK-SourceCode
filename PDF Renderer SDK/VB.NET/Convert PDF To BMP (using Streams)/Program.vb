'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'



Imports Bytescout.PDFRenderer
Imports System.IO


Class Program
    Friend Shared Sub Main(args As String())

        Dim srcStream = New FileStream("multipage.pdf", FileMode.Open)

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
        Using renderer = New RasterRenderer("demo", "demo")

            ' Load PDF document.
            renderer.LoadDocumentFromStream(srcStream)

            For i As Integer = 0 To renderer.GetPageCount() - 1

                Dim fileName As String = "page" & i & ".png"

                If File.Exists(fileName) Then File.Delete(fileName)

                ' Render first page of the document to PNG image file.
                Using destStream As New FileStream(fileName, FileMode.CreateNew)
                    renderer.Save(destStream, RasterImageFormat.PNG, i, 300)
                End Using

            Next

        End Using

        ' Open the first output file in default image viewer.
        System.Diagnostics.Process.Start("page0.png")

    End Sub
End Class
