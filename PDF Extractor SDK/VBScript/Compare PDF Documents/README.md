## compare PDF documents in VBScript using ByteScout PDF Extractor SDK

### compare PDF documents in VBScript

The documentation is designed to help you to implement the features on your side. ByteScout PDF Extractor SDK was made to help with compare PDF documents in VBScript. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout PDF Extractor SDK. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Test VBScript sample code examples whether they respond your needs and requirements for the project.

ByteScout PDF Extractor SDK is available as free trial. You may get it from our website along with all other source code samples for VBScript applications.

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