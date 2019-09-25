## How to make unsearchable PDF in VBScript with ByteScout PDF Extractor SDK

### This code in VBScript shows how to make unsearchable PDF with this how to tutorial

On this page you will learn from code samples for programming in VBScript.Writing of the code to make unsearchable PDF in VBScript can be done by developers of any level using ByteScout PDF Extractor SDK. ByteScout PDF Extractor SDK can make unsearchable PDF. It can be used from VBScript. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

This rich sample source code in VBScript for ByteScout PDF Extractor SDK includes the number of functions and options you should do calling the API to make unsearchable PDF. Just copy and paste the code into your VBScript application’s code and follow the instruction. Test VBScript sample code examples whether they respond your needs and requirements for the project.

ByteScout PDF Extractor SDK free trial version is available on our website. VBScript and other programming languages are supported.

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

##### ****MakeUnsearchablePDF.vbs:**
    
```
' Create Bytescout.PDFExtractor.UnsearchablePDFMaker object
Set unsearchablePDFMaker = CreateObject("Bytescout.PDFExtractor.UnsearchablePDFMaker")
unsearchablePDFMaker.RegistrationName = "demo"
unsearchablePDFMaker.RegistrationKey = "demo"

' Load sample PDF document
unsearchablePDFMaker.LoadDocumentFromFile("..\..\sample1.pdf")

' Set PDF rendering resolution to 150 DPI. Higher value - better quality, but larger output file.
unsearchablePDFMaker.RenderingResolution = 150
' Set embedded images format
unsearchablePDFMaker.ImageFormat = 0 ' JPEG = 0; PNG = 1
' Set quality factor for JPEG format; from 0 to 100; default is 90.
' Lower quality - smaller the result file.
unsearchablePDFMaker.JPEGQuality = 60

' Process the document
unsearchablePDFMaker.MakePDFUnsearchable("result.pdf")

WScript.Echo "Unsearchable document saved as 'result.pdf'."
```

<!-- code block end -->