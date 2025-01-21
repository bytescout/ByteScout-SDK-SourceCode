'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Collections.Generic
Imports Bytescout.PDFExtractor

Class Program
    Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.CSVExtractor instance
        Dim csvExtractor As New CSVExtractor()
        csvExtractor.RegistrationName = "demo"
        csvExtractor.RegistrationKey = "demo"

        ' Create Bytescout.PDFExtractor.TableDetector instance
        Dim tableDetector As New TableDetector2()
        tableDetector.RegistrationName = "demo"
        tableDetector.RegistrationKey = "demo"

        ' Load sample PDF document
        csvExtractor.LoadDocumentFromFile(".\sample_borderless.pdf")
        tableDetector.LoadDocumentFromFile(".\sample_borderless.pdf")

        ' Get page count
        Dim pageCount As Integer = tableDetector.GetPageCount()

        Dim extractedCsvFiles As New List(Of String)()

        For pageIndex As Integer = 0 To pageCount - 1
            Dim foundTables As DetectedTable() = tableDetector.FindTables(pageIndex).ToArray()

            ' Find first table And continue if found
            If foundTables.Length > 0 Then
                For indexTable As Integer = 0 To foundTables.Length - 1
                    ' Set extraction area for CSV extractor to rectangle received from the table detector
                    csvExtractor.SetExtractionArea(foundTables(indexTable).Bounds)

                    ' Result CSV file name
                    Dim outputCsvName As String = $"page-{pageIndex + 1}-table-{indexTable + 1}.csv"

                    ' Export the table to CSV file
                    csvExtractor.SavePageCSVToFile(pageIndex, outputCsvName)
                    extractedCsvFiles.Add(outputCsvName)
                Next
            End If
        Next

        ' Cleanup
        csvExtractor.Dispose()
        tableDetector.Dispose()

        ' Show Summary
        Console.Clear()
        If (extractedCsvFiles.Count > 0) Then
            Console.WriteLine($"Total {extractedCsvFiles.Count} tables found!")
            Console.WriteLine("--------------------------")
            Console.WriteLine(String.Join(Environment.NewLine, extractedCsvFiles))
        Else
            Console.WriteLine("No Table Found!")
        End If

        Console.ReadLine()

    End Sub
End Class
