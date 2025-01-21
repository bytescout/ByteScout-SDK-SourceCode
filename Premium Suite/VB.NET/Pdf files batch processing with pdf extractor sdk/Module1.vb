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
Imports System.IO

Module Module1

    Sub Main()

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim extractor = New TextExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Get PDF files 
        Dim pdfFiles() = Directory.GetFiles(".", "*.pdf")

        For Each file As String In pdfFiles

            ' Load document
            extractor.LoadDocumentFromFile(file)

            ' Save extracted text to .txt file
            extractor.SaveTextToFile(Path.ChangeExtension(file, ".txt"))

            ' Reset the extractor before load another file
            extractor.Reset()

        Next

        ' Cleanup
		extractor.Dispose()

    End Sub

End Module
