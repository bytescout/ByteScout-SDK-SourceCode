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

Module Module1

    Sub Main()

        ' Create Bytescout.PDFExtractor.AttachmentExtractor instance
        Dim extractor = New AttachmentExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\attachments.pdf")

        For i As Integer = 0 To extractor.Count - 1
            Console.WriteLine("Saving attachment: " + extractor.GetFileName(i))
            ' Save attachment to file
            extractor.Save(i, extractor.GetFileName(i))
            Console.WriteLine("File size: " + extractor.GetSize(i).ToString())
        Next

        ' Cleanup
		extractor.Dispose()

    End Sub

End Module
