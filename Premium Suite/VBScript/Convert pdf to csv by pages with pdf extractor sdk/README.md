## How to convert pdf to csv by pages with pdf extractor sdk in VBScript using ByteScout Premium Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to convert pdf to csv by pages with pdf extractor sdk in VBScript

Sample source code below will display you how to manage a complex task like convert pdf to csv by pages with pdf extractor sdk in VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can convert pdf to csv by pages with pdf extractor sdk in VBScript.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to convert pdf to csv by pages with pdf extractor sdk. Follow the instructions from scratch to work and copy the VBScript code. Complete and detailed tutorials and documentation are available along with installed ByteScout Premium Suite if you'd like to learn more about the topic and the details of the API.

You can download free trial version of ByteScout Premium Suite from our website to see and try many others source code samples for VBScript.

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

##### ****PdfToCsvByPages.vbs:**
    
```
' Create Bytescout.PDFExtractor.CSVExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.CSVExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"

' You can change CSV separator and quotation symbols if needed
'extractor.CSVSeparatorSymbol = "," 
'extractor.CSVQuotaionSymbol = "'" 

' Get page count
pageCount = extractor.GetPageCount()
		
For i = 0 To pageCount - 1

	fileName = "page" & i & ".csv"

	' Save extracted page text to file
	extractor.SavePageCSVToFile i, fileName
Next

WScript.Echo "Extracted data saved as 'page0.csv' and so on..."


```

<!-- code block end -->