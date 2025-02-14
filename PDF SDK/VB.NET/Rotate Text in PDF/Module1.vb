'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDF

Module Module1

    Sub Main()

        ' Create PDF document
        Dim document = New Document()
        document.RegistrationName = "demo"
        document.RegistrationKey = "demo"

        ' If you wish to load an existing document uncomment the line below And comment the Add page section instead
        ' pdfDocument.Load(".\existing_document.pdf")

        ' Create page
        Dim page = New Page(PaperFormat.A4)

        ' Add page to document
        document.Pages.Add(page)

        Dim canvas = page.Canvas

        ' Prepare font and brush
        Dim font = New Bytescout.PDF.Font(StandardFonts.Helvetica, 24)
        Dim blackBrush = New Bytescout.PDF.SolidBrush()


        ' Draw simple text
        canvas.DrawString("Simple text.", font, blackBrush, 50, 100)

        ' Save canvas state
        canvas.SaveGraphicsState()

        ' Move canvas origin (0,0) point to (50,100)
        canvas.TranslateTransform(50, 100)

        ' Rotate canvas at 45 deg around of the origin point
        canvas.RotateTransform(45)
        canvas.DrawString("Rotated 45", font, blackBrush, 0, 0)

        ' Rotate another 45 deg
        canvas.RotateTransform(45)
        canvas.DrawString("Rotated 90", font, blackBrush, 0, 0)

        ' Restore canvas state to reset all transformations
        canvas.RestoreGraphicsState()
        

        ' Save document
        document.Save("result.pdf")

        ' Open PDF document in default associated application (for demo puprpose)
        Process.Start("result.pdf")

    End Sub

End Module
