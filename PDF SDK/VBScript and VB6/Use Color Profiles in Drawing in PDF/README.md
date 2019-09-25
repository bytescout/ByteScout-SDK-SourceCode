## How to use color profiles in drawing in PDF in VBScript and VB6 with ByteScout PDF SDK

### This code in VBScript and VB6 shows how to use color profiles in drawing in PDF with this how to tutorial

On this page you will learn from code samples for programming in VBScript and VB6.Writing of the code to use color profiles in drawing in PDF in VBScript and VB6 can be done by developers of any level using ByteScout PDF SDK. Want to use color profiles in drawing in PDF in your VBScript and VB6 app? ByteScout PDF SDK is designed for it. ByteScout PDF SDK is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings.

This code snippet below for ByteScout PDF SDK works best when you need to quickly use color profiles in drawing in PDF in your VBScript and VB6 application. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. Test VBScript and VB6 sample code examples whether they respond your needs and requirements for the project.

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

##### ****ColorProfiles.vbs:**
    
```
' This example demonstrates how to use color profiles.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Load ICC color profile
Set iccProfile = comHelpers.CreateICCBasedColorspace("USWebCoatedSWOP.icc")
' Create profiled color brush
Set iccColor = comHelpers.CreateColorICC((iccProfile), comHelpers.CreateColorCMYK(0, 100, 0, 0))
Set iccBrush = comHelpers.CreateSolidBrush((iccColor))
' Draw a circle using the brush
page1.Canvas.DrawCircle_2 (iccBrush), 200, 200, 100

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->