## How to extract text from pdf with pdf extractor sdk in VBScript with ByteScout PDF Suite

### How to write a robust code in VBScript to extract text from pdf with pdf extractor sdk with this step-by-step tutorial

Extract text from pdf with pdf extractor sdk is simple to apply in VBScript if you use these source codes below. ByteScout PDF Suite: the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can extract text from pdf with pdf extractor sdk in VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout PDF Suite for VBScript plus the guidelines and the code below will help you quickly learn how to extract text from pdf with pdf extractor sdk.  Simply copy and paste in your VBScript project or application you and then run your app! If you want to use these VBScript sample examples in one or many applications then they can be used easily.

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

##### ****ExtractAllText.vbs:**
    
```
' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

' Save extracted text to file
extractor.SaveTextToFile("result.txt")

' Open the output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "result.txt", 1, false
Set shell = Nothing

Set extractor = Nothing


```

<!-- code block end -->