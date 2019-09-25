## How to extract pages from pdf with pdf extractor sdk in VBScript using ByteScout Premium Suite

### This code in VBScript shows how to extract pages from pdf with pdf extractor sdk with this how to tutorial

These source code samples are assembled by their programming language and functions they apply. ByteScout Premium Suite can extract pages from pdf with pdf extractor sdk. It can be applied from VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to extract pages from pdf with pdf extractor sdk.  Simply copy and paste in your VBScript project or application you and then run your app! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

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