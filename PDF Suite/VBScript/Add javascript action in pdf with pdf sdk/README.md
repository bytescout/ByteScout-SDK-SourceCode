## How to add javascript action in pdf with pdf sdk in VBScript and ByteScout PDF Suite

### Step-by-step tutorial on how to add javascript action in pdf with pdf sdk in VBScript

An easy to understand sample source code to learn how to add javascript action in pdf with pdf sdk in VBScript What is ByteScout PDF Suite? It is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to add javascript action in pdf with pdf sdk in your VBScript application.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout PDF Suite. Follow the instructions from scratch to work and copy the VBScript code. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### ****JavaScriptAction.vbs:**
    
```
' This example demonstrates how to add JavaScript actions to document events.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add action to document open event
Set onOpenDocument = comHelpers.CreateJavaScriptAction("app.alert(""OnOpenDocument"",3)")
pdfDocument.OnOpenDocument = onOpenDocument

' Add action to document close event
Set onBeforeClosing = comHelpers.CreateJavaScriptAction("app.alert(""OnBeforeClosing"",3)")
pdfDocument.OnBeforeClosing = onBeforeClosing

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->