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

''' <summary>
''' This example demonstrates how to add a text annotation.
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

        ' Add collapsed annotation (shown as a tooltip when mouse is over the icon)
        Dim collapsedAnnotation = New TextAnnotation(20, 20)
        collapsedAnnotation.Color = New ColorRGB(255, 255, 0)
        collapsedAnnotation.Icon = TextAnnotationIcon.Comment
        collapsedAnnotation.Author = "Mr. Important"
        collapsedAnnotation.Contents = "The quick brown fox jumps over the lazy dog."
        page.Annotations.Add(collapsedAnnotation)

        ' Add expanded annotation
        Dim expandedAnnotation = New TextAnnotation(20, 50)
        expandedAnnotation.Color = New ColorRGB(255, 0, 0)
        expandedAnnotation.Icon = TextAnnotationIcon.Note
        expandedAnnotation.Open = True
        expandedAnnotation.Author = "John Doe"
        expandedAnnotation.Contents = "The quick brown fox jumps over the lazy dog."
        page.Annotations.Add(expandedAnnotation)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
