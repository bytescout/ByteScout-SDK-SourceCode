'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.IO
Imports Bytescout.PDFExtractor

''' <summary>
''' The example demonstrates detection of empty pages, splitting the document to separate 
''' pages excluding empty ones, then combine parts back to a single document.
''' </summary>
Module Module1

    Dim InputFile = ".\sample.pdf"
    Dim OutputFile = ".\result.pdf"
    Dim TempFolder = ".\temp"

    Sub Main()

        ' Create and setup Bytescout.PDFExtractor.TextExtractor instance
        Dim extractor As New TextExtractor("demo", "demo")
        
        ' Load PDF document
        extractor.LoadDocumentFromFile(InputFile)

        ' List to keep non-empty page numbers
        Dim nonEmptyPages = New List(Of String)()

        ' Iterate through pages 
        For pageIndex = 0 To extractor.GetPageCount() - 1
            ' Extract page text
            Dim pageText = extractor.GetTextFromPage(pageIndex)
            ' If extracted text is not empty keep the page number
            If pageText.Length > 0 Then
                nonEmptyPages.Add((pageIndex + 1).ToString())
            End If
        Next
        
        ' Cleanup
        extractor.Dispose()


        ' Form comma-separated list of page numbers to split ("1,3,5")
        Dim ranges As String = String.Join(",", nonEmptyPages)

        ' Create Bytescout.PDFExtractor.DocumentSplitter instance
        Dim splitter = new DocumentSplitter("demo", "demo")
        splitter.OptimizeSplittedDocuments = true

        ' Split document by non-empty in temp folder
        Dim parts = splitter.Split(InputFile, ranges, TempFolder)

        ' Cleanup
        splitter.Dispose()

        
        ' Create Bytescout.PDFExtractor.DocumentMerger instance
        Dim merger = New DocumentMerger("demo", "demo")

        ' Merge parts
        merger.Merge(parts, OutputFile)

        ' Cleanup
        merger.Dispose()

        ' Delete temp folder
        Directory.Delete(TempFolder, true)
        

        ' Open the result file in default PDF viewer (for demo purposes)
        Process.Start(OutputFile)

    End Sub

End Module
