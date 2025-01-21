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
''' This example demonstrates how to add page numbers (labels) visible in the page thumbnails panel of PDF viewer.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        
        ' If you wish to load an existing document uncomment the line below And comment the Add page section instead
        ' pdfDocument.Load(".\existing_document.pdf")

        ' Add twenty pages
        For i As Integer = 0 To 19
            pdfDocument.Pages.Add(New Page(PaperFormat.A4))
        Next

        ' First five pages will have roman numbers I, II, III, ...
        Dim pageLabel = New PageLabel(0, PageNumberingStyle.UppercaseRoman)
        pdfDocument.PageLabels.Add(pageLabel)

        ' Next five pages will have arabic numbers 6, 7, 8, ...
        pageLabel.Style = PageNumberingStyle.DecimalArabic
        pageLabel.StartPortion = 6
        pageLabel.FirstPageIndex = 5
        pdfDocument.PageLabels.Add(pageLabel)

        ' Next five pages will have complex page numbers with prefix A-11, A-12, A-13, ...
        pageLabel.Style = PageNumberingStyle.DecimalArabic
        pageLabel.Prefix = "A-"
        pageLabel.StartPortion = 11
        pageLabel.FirstPageIndex = 10
        pdfDocument.PageLabels.Add(pageLabel)

        ' Next five pages will use letters as page numbers P, Q, R, ...
        pageLabel.Prefix = ""
        pageLabel.Style = PageNumberingStyle.UppercaseLetters
        pageLabel.StartPortion = 16
        pageLabel.FirstPageIndex = 15
        pdfDocument.PageLabels.Add(pageLabel)

        ' Force PDF viewer to show page thumbnails panel on start up
        pdfDocument.PageMode = PageMode.Thumbnail

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
