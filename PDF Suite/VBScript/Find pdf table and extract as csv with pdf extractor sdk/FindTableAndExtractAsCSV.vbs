'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.TextExtractor object
Set tableDetector= CreateObject("Bytescout.PDFExtractor.TableDetector")
tableDetector.RegistrationName = "demo"
tableDetector.RegistrationKey = "demo"

' Create Bytescout.PDFExtractor.CSVExtractor object
Set csvExtractor = CreateObject("Bytescout.PDFExtractor.CSVExtractor")
csvExtractor.RegistrationName = "demo"
csvExtractor.RegistrationKey = "demo"

' We should define what kind of tables we should detect.
' So we set min required number of columns to 3 ...
tableDetector.DetectionMinNumberOfColumns = 3
' ... and we set min required number of rows to 3
tableDetector.DetectionMinNumberOfRows = 3

' Set table detection mode to "bordered tables" - best for tables with closed solid borders.
tableDetector.ColumnDetectionMode = 3 ' 3 = ColumnDetectionMode.BorderedTables

' Load sample PDF document
tableDetector.LoadDocumentFromFile("sample3.pdf")
csvExtractor.LoadDocumentFromFile "sample3.pdf"

' Get page count
pageCount = tableDetector.GetPageCount()

' Iterate through pages
For i = 0 to pageCount - 1 
 
	t = 0
	' Find first table and continue if found
	If (tableDetector.FindTable(i)) Then

		Do
			' Set extraction area for CSV extractor to rectangle received from the table detector
			csvExtractor.SetExtractionArea _
				tableDetector.GetFoundTableRectangle_Left(), _
				tableDetector.GetFoundTableRectangle_Top(), _
				tableDetector.GetFoundTableRectangle_Width(), _
				tableDetector.GetFoundTableRectangle_Height()
			' Export the table to CSV file
			csvExtractor.SavePageCSVToFile i, "page-" & CStr(i) & "-table-" & CStr(t) & ".csv"
			t = t + 1
		Loop While tableDetector.FindNextTable()
		
	End If

Next

Set csvExtractor = Nothing
Set tableDetector = Nothing

