## How to copy pages from one PDF document to another in VBScript and VB6 and ByteScout PDF SDK

### This tutorial will show how to copy pages from one PDF document to another in VBScript and VB6

The sample source code below will teach you how to copy pages from one PDF document to another in VBScript and VB6. Want to copy pages from one PDF document to another in your VBScript and VB6 app? ByteScout PDF SDK is designed for it. ByteScout PDF SDK is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings.

Fast application programming interfaces of ByteScout PDF SDK for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to copy pages from one PDF document to another. In order to implement the functionality, you should copy and paste this code for VBScript and VB6 below into your code editor with your app, compile and run your application. Further enhancement of the code will make it more vigorous.

Trial version of ByteScout PDF SDK can be downloaded for free from our website. It also includes source code samples for VBScript and VB6 and other programming languages.

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