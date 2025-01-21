'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

Class Program

    Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.AttachmentExtractor instance
        Dim extractor As New AttachmentExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\ZUGFeRD-invoice.pdf")

        Dim i As Integer

        ' Extract the XML invoice that is stored as an attachment
        For i = 0 To extractor.Count - 1

            Console.WriteLine("Saving XML attachment: " + extractor.GetFileName(i))

            ' Save file to current folder
            extractor.Save(i, extractor.GetFileName(i))

            Console.WriteLine("Done.")
        Next

        ' Cleanup
		extractor.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadLine()

    End Sub
    
End Class
