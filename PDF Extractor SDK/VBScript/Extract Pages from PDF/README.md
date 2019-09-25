## How to extract pages from PDF in VBScript using ByteScout PDF Extractor SDK

### Tutorial on how to extract pages from PDF in VBScript

The code below will help you to implement an VBScript app to extract pages from PDF. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction. It can extract pages from PDF in VBScript.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Extractor SDK for extract pages from PDF below and use it in your application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Code testing will allow the function to be tested and work properly with your data.

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

##### ****SplitPDF.vbs:**
    
```
' Create Bytescout.PDFExtractor.DocumentSplitter object
Set splitter = CreateObject("Bytescout.PDFExtractor.DocumentSplitter")
splitter.RegistrationName = "demo"
splitter.RegistrationKey = "demo"

inputFile = "sample.pdf"

' Enable optimization of output documents
splitter.OptimizeSplittedDocuments = true

splitter.ExtractPage inputFile, "page3.pdf", 3 ' (!) Note: page number is 1-based.
                
WScript.Echo "Extracted page 3 to file page3.pdf"

' Split in two parts:
' ===================

splitter.Split inputFile, "part1.pdf", "part2.pdf", 3 ' (!) Note: page number is 1-based.

WScript.Echo "Splitted at page 3 to files part1.pdf and part2.pdf"

' Split by ranges:
' ================

' SplitCOM() returns array with a list of filenames
splittedParts = splitter.SplitCOM(inputFile, "1-3,4-6,7,8-") ' (!) Note: page numbers are 1-based; ending "-" means "to the end".

WScript.Echo "Splitted by ranges sucessfully"

' Display list of generated outputfiles
For Each file in splittedParts
    Wscript.Echo file
Next

```

<!-- code block end -->