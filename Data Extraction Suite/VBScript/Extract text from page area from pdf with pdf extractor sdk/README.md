## How to extract text from page area from pdf with pdf extractor sdk in VBScript with ByteScout Data Extraction Suite

### How to write a robust code in VBScript to extract text from page area from pdf with pdf extractor sdk with this step-by-step tutorial

The sample source code below will teach you how to extract text from page area from pdf with pdf extractor sdk in VBScript. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK and you can use it to extract text from page area from pdf with pdf extractor sdk with VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Data Extraction Suite for extract text from page area from pdf with pdf extractor sdk below and use it in your application. Just copy and paste the code into your VBScript application’s code and follow the instructions. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

ByteScout provides the free trial version of ByteScout Data Extraction Suite along with the documentation and source code samples.

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

##### ****ExtractTextFromPageArea.vbs:**
    
```
' Create TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

' Get page count
pageCount = extractor.GetPageCount()

' Iterate through pages
For i = 0 to pageCount - 1

	' Set extraction area (in Points. 1 Point = 1/72 in.)
	extractor.SetExtractionArea 0, 0, 200, 200
	
	' Extract text from the extraction area
	text = extractor.GetTextFromPage(i)

	Wscript.echo "Page #" & CStr(i) & " text from area (0, 0, 200, 200): " & vbCr & vbLf & text

	extractor.ResetExtractionArea
	
Next

Set extractor = Nothing


```

<!-- code block end -->