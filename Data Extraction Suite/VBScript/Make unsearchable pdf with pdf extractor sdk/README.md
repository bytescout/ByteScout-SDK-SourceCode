## How to make unsearchable pdf with pdf extractor sdk in VBScript using ByteScout Data Extraction Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to make unsearchable pdf with pdf extractor sdk in VBScript

Source code documentation samples give simple and easy method to install a needed feature into your application. ByteScout Data Extraction Suite is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK and you can use it to make unsearchable pdf with pdf extractor sdk with VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Data Extraction Suite for VBScript plus the guidelines and the code below will help you quickly learn how to make unsearchable pdf with pdf extractor sdk. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample codes in VBScript.

ByteScout Data Extraction Suite free trial version is available on our website. VBScript and other programming languages are supported.

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