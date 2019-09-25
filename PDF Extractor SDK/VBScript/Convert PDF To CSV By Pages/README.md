## How to convert PDF to CSV by pages in VBScript with ByteScout PDF Extractor SDK

### The tutorial shows how to convert PDF to CSV by pages in VBScript

This sample source code below will demonstrate you how to convert PDF to CSV by pages in VBScript. What is ByteScout PDF Extractor SDK? It is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker. It can help you to convert PDF to CSV by pages in your VBScript application.

Fast application programming interfaces of ByteScout PDF Extractor SDK for VBScript plus the instruction and the code below will help you quickly learn how to convert PDF to CSV by pages. In your VBScript project or application you may simply copy & paste the code and then run your app! Further enhancement of the code will make it more vigorous.

Free trial version of ByteScout PDF Extractor SDK is available for download from our website. Get it to try other source code samples for VBScript.

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