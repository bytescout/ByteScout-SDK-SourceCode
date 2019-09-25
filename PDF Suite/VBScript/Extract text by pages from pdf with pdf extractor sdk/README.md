## How to extract text by pages from pdf with pdf extractor sdk in VBScript with ByteScout PDF Suite

### Learn to extract text by pages from pdf with pdf extractor sdk in VBScript

An easy to understand sample source code to learn how to extract text by pages from pdf with pdf extractor sdk in VBScript ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can extract text by pages from pdf with pdf extractor sdk in VBScript.

The following code snippet for ByteScout PDF Suite works best when you need to quickly extract text by pages from pdf with pdf extractor sdk in your VBScript application. Follow the instructions from scratch to work and copy the VBScript code. Enjoy writing a code with ready-to-use sample codes in VBScript.

Trial version of ByteScout PDF Suite is available for free. Source code samples are included to help you with your VBScript app.

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

##### ****ExtractTextByPages.vbs:**
    
```
' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample2.pdf")

' Get page count
pageCount = extractor.GetPageCount()
		
For i = 0 To pageCount - 1
	fileName = "page" & i & ".txt"

	' Save extracted page text to file
	extractor.SavePageTextToFile i, fileName
Next

' Open first output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "page0.txt", 1, false
Set shell = Nothing

Set extractor = Nothing


```

<!-- code block end -->