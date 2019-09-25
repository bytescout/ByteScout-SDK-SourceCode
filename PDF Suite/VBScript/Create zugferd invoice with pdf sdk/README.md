## How to create zugferd invoice with pdf sdk in VBScript and ByteScout PDF Suite

### How to write a robust code in VBScript to create zugferd invoice with pdf sdk with this step-by-step tutorial

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout PDF Suite can create zugferd invoice with pdf sdk. It can be applied from VBScript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

This prolific sample source code in VBScript for ByteScout PDF Suite contains various functions and other necessary options you should do calling the API to create zugferd invoice with pdf sdk. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Further improvement of the code will make it more robust.

Our website gives trial version of ByteScout PDF Suite for free. It also includes documentation and source code samples.

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

##### ****FileAttachmentAnnotations.vbs:**
    
```
' This example demonstrates how to attach a file to PDF document.

' Open pdf document
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' Load existing document
pdfDocument.Load("Invoice.pdf")

Set comHelpers = pdfDocument.ComHelpers

' Attach ZUGFeRD XML file
Set fileAttachment = comHelpers.CreateFileAttachmentAnnotation("ZUGFeRD-invoice.xml", 0, 0, 0, 0)
pdfDocument.Pages.Item(0).Annotations.Add(fileAttachment)

' Instruct PDF viewer applications to show attachments pane on startup (optional)
pdfDocument.PageMode = comHelpers.PAGEMODE_ATTACHMENT

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
```

<!-- code block end -->