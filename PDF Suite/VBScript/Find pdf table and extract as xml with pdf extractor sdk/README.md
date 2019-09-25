## How to find pdf table and extract as xml with pdf extractor sdk in VBScript using ByteScout PDF Suite

### Step-by-step tutorial on how to find pdf table and extract as xml with pdf extractor sdk in VBScript

Quickly learn how to find pdf table and extract as xml with pdf extractor sdk in VBScript with this sample source code. ByteScout PDF Suite: the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can find pdf table and extract as xml with pdf extractor sdk in VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for find pdf table and extract as xml with pdf extractor sdk below and use it in your application. Follow the instructions from scratch to work and copy the VBScript code. Enjoy writing a code with ready-to-use sample VBScript codes.

ByteScout provides the free trial version of ByteScout PDF Suite along with the documentation and source code samples.

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