## How to convert pdf to xfdf with pdf extractor sdk in VBScript with ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to convert pdf to xfdf with pdf extractor sdk in VBScript

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. What is ByteScout PDF Suite? It is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to convert pdf to xfdf with pdf extractor sdk in your VBScript application.

The SDK samples given below describe how to quickly make your application do convert pdf to xfdf with pdf extractor sdk in VBScript with the help of ByteScout PDF Suite. Follow the instructions from scratch to work and copy the VBScript code. Use of ByteScout PDF Suite in VBScript is also described in the documentation included along with the product.

You can download free trial version of ByteScout PDF Suite from our website to see and try many others source code samples for VBScript.

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

##### ****PDFToXFDF.vbs:**
    
```
' Create Bytescout.PDFExtractor.XFDFExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XFDFExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"

extractor.SaveXFDFToFile "output.xml"

WScript.Echo "Extracted data saved to 'output.xml' file."

```

<!-- code block end -->