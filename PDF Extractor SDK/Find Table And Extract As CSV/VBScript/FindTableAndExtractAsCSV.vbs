'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.TextExtractor object
Set tdetector= CreateObject("Bytescout.PDFExtractor.TableDetector")
tdetector.RegistrationName = "demo"
tdetector.RegistrationKey = "demo"

' Create Bytescout.PDFExtractor.CSVExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.CSVExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' we should define what kind of tables we should detect
' so we set min required number of columns to 3
tdetector.DetectionMinNumberOfColumns = 3

' and we set min required number of columns to 3
tdetector.DetectionMinNumberOfRows = 3



' Load sample PDF document into table detector
tdetector.LoadDocumentFromFile("..\..\sample3.pdf")

' Load sample PDF document into CSV extractor
extractor.LoadDocumentFromFile "..\..\sample3.pdf"

' Get page count

pageCount = tdetector.GetPageCount()

For i=0 to PageCount-1 
 
 If tdetector.FindTable(i) Then ' parameters are: page index, string to find, case sensitivity
 	Do
 		MsgBox "Found a table on page #" & CStr(i) & " at left=" & CStr(tdetector.GetFoundTableRectangle_Left) & "; top=" & CStr(tdetector.GetFoundTableRectangle_Top) & "; width=" & CStr(tdetector.GetFoundTableRectangle_Width) & "; height=" & CStr(tdetector.GetFoundTableRectangle_Height)

	
	' set extraction area to extract table data as CSV
	extractor.SetExtractionArea tdetector.GetFoundTableRectangle_Left, tdetector.GetFoundTableRectangle_Top, tdetector.GetFoundTableRectangle_Width, tdetector.GetFoundTableRectangle_Height

	' define filename to save CSV
 	CSVFileName = "page-" & CStr(i) & "-table-at-" & CStr(tdetector.GetFoundTableRectangle_Top) & ".csv"

	' save CSV from this page (bounded by extraction area) into file
	extractor.SavePageCSVToFile i, CSVFileName

	MsgBox "Table saved into CSV as " & CSVFileName

	' reset extraction area on the page
	extractor.ResetExtractionArea


  	Loop While tdetector.FindNextTable
 End If

Next

MsgBox "Done"

Set tdetector= Nothing

