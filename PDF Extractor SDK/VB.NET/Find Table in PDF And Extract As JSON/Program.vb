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

        ' Create Bytescout.PDFExtractor.CSVExtractor instance
        Dim jsonExtractor As New JSONExtractor()
        jsonExtractor.RegistrationName = "demo"
        jsonExtractor.RegistrationKey = "demo"

        ' Create Bytescout.PDFExtractor.TableDetector instance
        Dim tableDetector As New TableDetector()
        tableDetector.RegistrationName = "demo"
        tableDetector.RegistrationKey = "demo"

        ' We should define what kind of tables we should detect.
        ' So we set min required number of columns to 3 ...
        tableDetector.DetectionMinNumberOfColumns = 3
        ' ... and we set min required number of rows to 3
        tableDetector.DetectionMinNumberOfRows = 3

        ' Set table detection mode to "bordered tables" - best for tables with closed solid borders.
        tableDetector.ColumnDetectionMode = ColumnDetectionMode.BorderedTables

        ' Load sample PDF document
        jsonExtractor.LoadDocumentFromFile(".\sample3.pdf")
        tableDetector.LoadDocumentFromFile(".\sample3.pdf")

		' Get page count
        Dim pageCount As Integer = tableDetector.GetPageCount()

        ' Iterate through pages
		For i As Integer = 0 To pageCount - 1
            Dim t As Integer = 1
            ' Find first table and continue if found
            If (tableDetector.FindTable(i)) Then
                Do
                    ' Set extraction area for JSON extractor to rectangle received from the table detector
                    jsonExtractor.SetExtractionArea(tableDetector.FoundTableLocation)
                    ' Export the table to JSON file
                    jsonExtractor.SaveJSONToFile(i, "page-" + i.ToString() + "-table-" + t.ToString() + ".json")
                    t = t + 1
                Loop While tableDetector.FindNextTable()
            End If
        Next

        ' Cleanup
        jsonExtractor.Dispose()
        tableDetector.Dispose()

        ' Open first output file in default associated application (for demo purposes)
        System.Diagnostics.Process.Start("page-0-table-1.json")

    End Sub
End Class
