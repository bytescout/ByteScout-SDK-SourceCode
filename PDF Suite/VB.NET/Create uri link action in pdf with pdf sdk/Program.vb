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
''' This example demonstrates how to create URI (link) action.
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

        ' Set Url action
        Dim action As New URIAction(New Uri("https://bytescout.com"))

        ' Add link annotation
        Dim linkAnnotation As New LinkAnnotation(action, 20, 20, 150, 25)

        ' Set highlight mode
        linkAnnotation.HighlightingMode = LinkAnnotationHighlightingMode.Outline

        ' Set color
        linkAnnotation.Color = New ColorRGB(0, 0, 255)

        ' Add Link
        page.Annotations.Add(linkAnnotation)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
