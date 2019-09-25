## How to find pdf table and extract as xml with pdf extractor sdk in VBScript and ByteScout Data Extraction Suite

### How to write a robust code in VBScript to find pdf table and extract as xml with pdf extractor sdk with this step-by-step tutorial

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. ByteScout Data Extraction Suite is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can find pdf table and extract as xml with pdf extractor sdk in VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Data Extraction Suite for find pdf table and extract as xml with pdf extractor sdk below and use it in your application. Follow the instructions from scratch to work and copy the VBScript code. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

ByteScout Data Extraction Suite free trial version is available on our website. VBScript and other programming languages are supported.

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

##### ****FindTableAndExtractAsXML.vbs:**
    
```
' Create Bytescout.PDFExtractor.TextExtractor object
Set tableDetector= CreateObject("Bytescout.PDFExtractor.TableDetector")
tableDetector.RegistrationName = "demo"
tableDetector.RegistrationKey = "demo"

' Create Bytescout.PDFExtractor.xmlExtractor object
Set xmlExtractor = CreateObject("Bytescout.PDFExtractor.XMLExtractor")
xmlExtractor.RegistrationName = "demo"
xmlExtractor.RegistrationKey = "demo"

' We should define what kind of tables we should detect.
' So we set min required number of columns to 3 ...
tableDetector.DetectionMinNumberOfColumns = 3
' ... and we set min required number of rows to 3
tableDetector.DetectionMinNumberOfRows = 3

' Load sample PDF document
tableDetector.LoadDocumentFromFile("..\..\sample3.pdf")
xmlExtractor.LoadDocumentFromFile "..\..\sample3.pdf"

' Get page count
pageCount = tableDetector.GetPageCount()

' Iterate through pages
For i = 0 to pageCount - 1 
 
	t = 0
	' Find first table and continue if found
	If (tableDetector.FindTable(i)) Then

		Do
			' Set extraction area for CSV extractor to rectangle received from the table detector
			xmlExtractor.SetExtractionArea _
				tableDetector.GetFoundTableRectangle_Left(), _
				tableDetector.GetFoundTableRectangle_Top(), _
				tableDetector.GetFoundTableRectangle_Width(), _
				tableDetector.GetFoundTableRectangle_Height()
			' Export the table to CSV file
			xmlExtractor.SavePageXMLToFile i, "page-" & CStr(i) & "-table-" & CStr(t) & ".xml"
			t = t + 1
		Loop While tableDetector.FindNextTable()
		
	End If

Next

Set xmlExtractor = Nothing
Set tableDetector = Nothing


```

<!-- code block end -->