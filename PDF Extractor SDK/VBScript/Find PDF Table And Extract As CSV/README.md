## How to find PDF table and extract as CSV in VBScript and ByteScout PDF Extractor SDK

### The tutorial shows how to find PDF table and extract as CSV in VBScript

This sample source code below will demonstrate you how to find PDF table and extract as CSV in VBScript. Want to find PDF table and extract as CSV in your VBScript app? ByteScout PDF Extractor SDK is designed for it. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Extractor SDK for find PDF table and extract as CSV below and use it in your application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Test VBScript sample code examples whether they respond your needs and requirements for the project.

Trial version of ByteScout PDF Extractor SDK is available for free. Source code samples are included to help you with your VBScript app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




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