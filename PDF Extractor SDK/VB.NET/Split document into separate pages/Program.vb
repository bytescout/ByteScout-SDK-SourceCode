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


' This example demonstrates how to split document into seperate pages

Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports Bytescout.PDFExtractor

Class Program

    Friend Shared Sub Main(args As String())

        Dim inputFile As String = "sample.pdf"

        Using splitter As New DocumentSplitter("demo", "demo")

            splitter.OptimizeSplittedDocuments = True

            '# Create list of page numbers in form "1,2,3,4,5,...,n" #
            ' 1. Get Page Count
            Dim pageCount As Int32 = splitter.GetPageCount(inputFile)
            ' 2. Get all page numbers
            Dim pageNumbers As IEnumerable(Of Int32) = Enumerable.Range(1, pageCount)
            ' 3. Split Range
            Dim splitRange As String = String.Join(",", pageNumbers)

            ' Perform split by ranges
            Dim files As String() = splitter.Split(inputFile, splitRange)

            Console.WriteLine("Splitted by parts: ")
            For Each file As String In files
                Console.WriteLine("    " + Path.GetFullPath(file))
            Next

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadKey()

    End Sub

End Class
