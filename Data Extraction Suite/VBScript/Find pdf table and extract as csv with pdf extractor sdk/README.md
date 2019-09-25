## How to find pdf table and extract as csv with pdf extractor sdk in VBScript using ByteScout Data Extraction Suite

### Learn to code in VBScript to find pdf table and extract as csv with pdf extractor sdk with this step-by-step tutorial

An easy to understand guide on how to find pdf table and extract as csv with pdf extractor sdk in VBScript with this source code sample. ByteScout Data Extraction Suite: the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can find pdf table and extract as csv with pdf extractor sdk in VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Data Extraction Suite. Just copy and paste the code into your VBScript application’s code and follow the instructions. Further improvement of the code will make it more robust.

You can download free trial version of ByteScout Data Extraction Suite from our website to see and try many others source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****FindTableAndExtractAsCSV.vbs:**
    
```
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
tableDetector.LoadDocumentFromFile("..\..\sample3.pdf")
csvExtractor.LoadDocumentFromFile "..\..\sample3.pdf"

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


```

<!-- code block end -->