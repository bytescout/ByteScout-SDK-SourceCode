## How to find pdf table and extract as csv with pdf extractor sdk in VBScript with ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to find pdf table and extract as csv with pdf extractor sdk in VBScript

These source code samples are assembled by their programming language and functions they apply. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can find pdf table and extract as csv with pdf extractor sdk in VBScript.

This prolific sample source code in VBScript for ByteScout PDF Suite contains various functions and other necessary options you should do calling the API to find pdf table and extract as csv with pdf extractor sdk. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. If you want to use these VBScript sample examples in one or many applications then they can be used easily.

You can download free trial version of ByteScout PDF Suite from our website with this and other source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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