## How to copy pages from one pdf document to another with pdf sdk in VBScript and ByteScout PDF Suite

### How to write a robust code in VBScript to copy pages from one pdf document to another with pdf sdk with this step-by-step tutorial

Quickly learn how to copy pages from one pdf document to another with pdf sdk in VBScript with this sample source code. What is ByteScout PDF Suite? It is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to copy pages from one pdf document to another with pdf sdk in your VBScript application.

The SDK samples given below describe how to quickly make your application do copy pages from one pdf document to another with pdf sdk in VBScript with the help of ByteScout PDF Suite. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

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

##### ****CopyPagesFromOneDocumentToAnother.vbs:**
    
```
' This example demonstrates how to copy pages from one document to another

' Open first document
Set pdfDocument1 = CreateObject("Bytescout.PDF.Document")
pdfDocument1.RegistrationName = "demo"
pdfDocument1.RegistrationKey = "demo"
pdfDocument1.Load("document1.pdf")
' Open second document
Set pdfDocument2 = CreateObject("Bytescout.PDF.Document")
pdfDocument2.RegistrationName = "demo"
pdfDocument2.RegistrationKey = "demo"
pdfDocument2.Load("document2.pdf")

' Add pages from document2 to document1
For i = 0 To pdfDocument2.Pages.Count - 1
    pdfDocument1.Pages.Add(pdfDocument2.Pages.Item(i))
Next

' Save document to file
pdfDocument1.Save("merged.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "merged.pdf", 1, false

```

<!-- code block end -->