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
''' This example demonstrates how to add JavaScript actions to document events.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        ' If you wish to load an existing document uncomment the line below And comment the Add page section instead
        ' pdfDocument.Load(".\existing_document.pdf")

		' Add page
        pdfDocument.Pages.Add(New Page(PaperFormat.A4))

        ' Add action to document open event
        Dim onOpenDocument = New JavaScriptAction("app.alert(""OnOpenDocument"",3)")
        pdfDocument.OnOpenDocument = onOpenDocument

        ' Add action to document close event
        Dim onBeforeClosing = New JavaScriptAction("app.alert(""OnBeforeClosing"",3)")
        pdfDocument.OnBeforeClosing = onBeforeClosing

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
