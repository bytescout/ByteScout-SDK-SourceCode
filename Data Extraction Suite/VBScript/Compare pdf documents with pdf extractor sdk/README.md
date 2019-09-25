## compare pdf documents with pdf extractor sdk in VBScript with ByteScout Data Extraction Suite

### Simple tutorial on how to do compare pdf documents with pdf extractor sdk in VBScript

Easy to understand coding instructions are written to assist you to try-out the features without the requirement to write your own code. ByteScout Data Extraction Suite was made to help with compare pdf documents with pdf extractor sdk in VBScript. ByteScout Data Extraction Suite is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

Save time on writing and testing code by using the code below and use it in your application. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. This basic programming language sample code for VBScript will do the whole work for you in implementing compare pdf documents with pdf extractor sdk in your app.

Trial version can be downloaded from our website for free. It contains this and other source code samples for VBScript.

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

##### ****CompareDocuments.vbs:**
    
```
' Create TextComparer object
Set comparer = CreateObject("Bytescout.PDFExtractor.TextComparer")
comparer.RegistrationName = "demo"
comparer.RegistrationKey = "demo"

'Compare documents
comparer.Compare "..\..\comparison1.pdf", "..\..\comparison2.pdf"

' Generate report
comparer.GenerateHtmlReport "report.html"

' Open output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "report.html", 1, false


```

<!-- code block end -->