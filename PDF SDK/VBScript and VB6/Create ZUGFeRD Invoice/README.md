## How to create zugferd invoice in VBScript and VB6 and ByteScout PDF SDK

### This tutorial will show how to create zugferd invoice in VBScript and VB6

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout PDF SDK can create zugferd invoice. It can be used from VBScript and VB6. ByteScout PDF SDK is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout PDF SDK. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Detailed tutorials and documentation are available along with installed ByteScout PDF SDK if you'd like to dive deeper into the topic and the details of the API.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gdsQ0EAqwGQ](https://www.youtube.com/watch?v=gdsQ0EAqwGQ)




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