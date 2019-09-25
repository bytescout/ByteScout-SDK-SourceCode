## How to reduce memory usage for PDF extraction in VBScript and ByteScout PDF Extractor SDK

### The tutorial below will demonstrate how to reduce memory usage for PDF extraction in VBScript

With this source code sample you may quickly learn how to reduce memory usage for PDF extraction in VBScript. Want to reduce memory usage for PDF extraction in your VBScript app? ByteScout PDF Extractor SDK is designed for it. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

This rich sample source code in VBScript for ByteScout PDF Extractor SDK includes the number of functions and options you should do calling the API to reduce memory usage for PDF extraction. Follow the instructions from the scratch to work and copy the VBScript code. This basic programming language sample code for VBScript will do the whole work for you to reduce memory usage for PDF extraction.

You can download free trial version of ByteScout PDF Extractor SDK from our website to see and try many others source code samples for VBScript.

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

##### ****ReduceMemoryUsage.vbs:**
    
```
' When processing huge PDF documents you may run into OutOfMemoryException.
' This example demonstrates a way to spare the memory by disabling page data caching.
            
' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample2.pdf")

' Disable page data caching, so processed pages wiil be disposed automatically
extractor.PageDataCaching = 0 ' 0 - no caching; 1 - cache all pages.

' Save extracted text to file
extractor.SaveTextToFile("output.txt")

Set extractor = Nothing

WScript.Echo "Extracted data saved to 'output.txt' file."
```

<!-- code block end -->