## How to extract text from page area from pdf with pdf extractor sdk in VBScript using ByteScout Premium Suite

### Step-by-step tutorial on how to extract text from page area from pdf with pdf extractor sdk in VBScript

An easy to understand sample source code to learn how to extract text from page area from pdf with pdf extractor sdk in VBScript ByteScout Premium Suite can extract text from page area from pdf with pdf extractor sdk. It can be applied from VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Premium Suite. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample codes in VBScript.

Our website gives trial version of ByteScout Premium Suite for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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