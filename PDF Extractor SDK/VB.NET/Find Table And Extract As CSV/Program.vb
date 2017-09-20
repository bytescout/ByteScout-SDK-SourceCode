'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


Imports Bytescout.PDFExtractor

Class Program
	Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.CSVExtractor instance
        Dim csvExtractor As New CSVExtractor()
        csvExtractor.RegistrationName = "demo"
        csvExtractor.RegistrationKey = "demo"

        ' Create Bytescout.PDFExtractor.TableDetector instance
        Dim tableDetector As New TableDetector()
        tableDetector.RegistrationName = "demo"
        tableDetector.RegistrationKey = "demo"

        ' We should define what kind of tables we should detect.
        ' So we set min required number of columns to 3 ...
        tableDetector.DetectionMinNumberOfColumns = 3
        ' ... and we set min required number of columns to 3
        tableDetector.DetectionMinNumberOfRows = 3

		' Load sample PDF document
        csvExtractor.LoadDocumentFromFile(".\sample3.pdf")
        tableDetector.LoadDocumentFromFile(".\sample3.pdf")

		' Get page count
        Dim pageCount As Integer = tableDetector.GetPageCount()

		For i As Integer = 0 To pageCount - 1
            Dim t As Integer = 1
            ' Find first table and continue if found
            If (tableDetector.FindTable(i)) Then
                Do
                    ' Set extraction area for CSV extractor to rectangle received from the table detector
                    csvExtractor.SetExtractionArea(tableDetector.FoundTableLocation)
                    ' Export the table to CSV file
                    csvExtractor.SavePageCSVToFile(i, "page-" + i.ToString() + "-table-" + t.ToString() + ".csv")
                    t = t + 1
                Loop While tableDetector.FindNextTable()
            End If
        Next

        ' Open first output file in default associated application (for demo purposes)
        System.Diagnostics.Process.Start("page-0-table-1.csv")

	End Sub
End Class
