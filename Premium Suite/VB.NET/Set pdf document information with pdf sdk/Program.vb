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
''' This example demonstrates how to set various document properties.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
		pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
		' Add page
        pdfDocument.Pages.Add(New Page(PaperFormat.A4))
		
        ' Change document information.
        ' Open Document Properties in PDF viewer to see the changes.
        pdfDocument.DocumentInfo.Author = "John Doe"
        pdfDocument.DocumentInfo.Creator = "My Application"
        pdfDocument.DocumentInfo.Keywords = "accounting,invoice"
        pdfDocument.DocumentInfo.Title = "Invoice #12345"
        pdfDocument.DocumentInfo.Subject = "Invoice"
        pdfDocument.DocumentInfo.CreationDate = New DateTime(2015, 12, 21)
        pdfDocument.DocumentInfo.ModificationDate = DateTime.Now
        
        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
