## How to reduce memory usage for pdf extraction with pdf extractor sdk in VBScript and ByteScout PDF Suite

### This code in VBScript shows how to reduce memory usage for pdf extraction with pdf extractor sdk with this how to tutorial

Source code documentation samples give simple and easy method to install a needed feature into your application. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can reduce memory usage for pdf extraction with pdf extractor sdk in VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout PDF Suite. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout PDF Suite in VBScript is also described in the documentation included along with the product.

ByteScout PDF Suite free trial version is available on our website. VBScript and other programming languages are supported.

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