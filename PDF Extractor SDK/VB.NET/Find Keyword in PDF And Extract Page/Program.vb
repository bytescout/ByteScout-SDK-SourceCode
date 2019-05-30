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


' This example page extraction by found keyword.

Imports Bytescout.PDFExtractor

Class Program

    Friend Shared Sub Main(args As String())

        Dim inputFile As String = ".\sample2.pdf"

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim extractor As New TextExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(inputFile)

        Dim pageCount As Integer = extractor.GetPageCount()

        ' Search each page for a keyword 
        For i As Integer = 0 To pageCount - 1

            If extractor.Find(i, "bombardment", False) Then

                ' Extract page
                Using splitter As New DocumentSplitter("demo", "demo")

                    splitter.OptimizeSplittedDocuments = True

                    Dim pageNumber As Integer = i + 1
                    ' (!) page number in ExtractPage() is 1-based
                    Dim outputFile As String = ".\page" & pageNumber.ToString() & ".pdf"
                    splitter.ExtractPage(inputFile, outputFile, pageNumber)

                    Console.WriteLine("Extracted page " & pageNumber.ToString() & " to file """ & outputFile & """")

                End Using
            End If
        Next

        ' Cleanup
		extractor.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadKey()
        
    End Sub
End Class
