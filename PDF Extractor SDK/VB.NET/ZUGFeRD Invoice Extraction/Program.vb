'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
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
