'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to attach a file to PDF document.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new PDF document
        Dim pdfDocument = New Document()
		pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"

        ' Load existing document
        pdfDocument.Load(".\Invoice.pdf")

        ' Attach ZUGFeRD XML file
        Dim fileAttachment As New Bytescout.PDF.FileAttachmentAnnotation(".\ZUGFeRD-invoice.xml", 0, 0, 0, 0)
        pdfDocument.Pages.Item(0).Annotations.Add(fileAttachment)

        ' Instruct PDF viewer applications to show attachment page on startup
        pdfDocument.PageMode = PageMode.Attachment

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup
        pdfDocument.Dispose()

        ' Open result document in default associated application (for demo puropse)
        Dim processStartInfo As New ProcessStartInfo("result.pdf")
        processStartInfo.UseShellExecute = True
        Process.Start(processStartInfo)

    End Sub

End Class
