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


Imports System.IO
Imports Bytescout.PDFExtractor

Class Program

    Shared Sub Main(ByVal args As String())

        Dim searchablePDFStream As New MemoryStream()

        ' STEP-1 Make Searchable PDF
        ' STEP-2: Get search text result from that searchable PDF
        ' STEP-3: Remove sensitive data

        ' Create Bytescout.PDFExtractor.SearchablePDFMaker instance
        Using searchablePDFMaker As New SearchablePDFMaker("demo", "demo")

            ' Load sample PDF document
            searchablePDFMaker.LoadDocumentFromFile("sampleScannedPDF_EmailAddress.pdf")

            ' Set the location of language data files
            searchablePDFMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

            ' Set OCR language
            searchablePDFMaker.OCRLanguage = "eng" ' "eng" For english, "deu" For German, "fra" For French, "spa" For Spanish etc - according To files In "ocrdata" folder

            ' Set PDF document rendering resolution
            searchablePDFMaker.OCRResolution = 300

            ' Save extracted text to file
            searchablePDFMaker.MakePDFSearchable(searchablePDFStream)


            ' Prepare TextExtractor
            Using textExtractor As New TextExtractor("demo", "demo")

                ' Load stream into TextExtractor
                textExtractor.LoadDocumentFromStream(searchablePDFStream)

                ' Search email Addresses
                'See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx
                Dim regexPattern As String = "\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}\b"

                ' Enable RegexSearch
                textExtractor.RegexSearch = True

                ' Set word matching options
                textExtractor.WordMatchingMode = WordMatchingMode.None

                Dim searchResults() As ISearchResult = textExtractor.FindAll(0, regexPattern, caseSensitive:=False)

                ' Create Bytescout.PDFExtractor.Remover instance
                Using remover As New Remover2("demo", "demo")

                    ' Load sample PDF document
                    remover.LoadDocumentFromStream(searchablePDFStream)

                    ' Mask removed text
                    remover.MaskRemovedText = True

                    ' Make output file unsearchable
                    remover.MakePDFUnsearchable = True

                    ' Provide text to remove
                    remover.AddTextToRemove(searchResults)

                    ' Remove text objects find by SearchResults.
                    remover.PerformRemoval("result1.pdf")

                End Using

            End Using

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue and open result PDF files in default PDF viewer...")
        Console.ReadKey()

        Dim processStartInfo As New ProcessStartInfo("result1.pdf")
        processStartInfo.UseShellExecute = True
        Process.Start(processStartInfo)

    End Sub

End Class
