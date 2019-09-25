## How to make unsearchable pdf with pdf extractor sdk in VBScript using ByteScout PDF Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to make unsearchable pdf with pdf extractor sdk in VBScript

An easy to understand guide on how to make unsearchable pdf with pdf extractor sdk in VBScript with this source code sample. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript and you can use it to make unsearchable pdf with pdf extractor sdk with VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout PDF Suite. Follow the instructions from scratch to work and copy the VBScript code. Use of ByteScout PDF Suite in VBScript is also described in the documentation included along with the product.

ByteScout provides the free trial version of ByteScout PDF Suite along with the documentation and source code samples.

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