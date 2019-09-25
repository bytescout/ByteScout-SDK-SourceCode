## How to extract text from page area from PDF in VBScript and ByteScout PDF Extractor SDK

### This tutorial will show how to extract text from page area from PDF in VBScript

This sample source code below will demonstrate you how to extract text from page area from PDF in VBScript. Want to extract text from page area from PDF in your VBScript app? ByteScout PDF Extractor SDK is designed for it. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Extractor SDK for extract text from page area from PDF below and use it in your application. In your VBScript project or application you may simply copy & paste the code and then run your app! Further enhancement of the code will make it more vigorous.

Free trial version of ByteScout PDF Extractor SDK is available on our website. Documentation and source code samples are included.

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