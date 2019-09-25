## How to add video annotation to PDF in VBScript and VB6 with ByteScout PDF SDK

### This tutorial will show how to add video annotation to PDF in VBScript and VB6

The sample shows steps and algorithm of how to add video annotation to PDF and how to make it work in your VBScript and VB6 application. Want to add video annotation to PDF in your VBScript and VB6 app? ByteScout PDF SDK is designed for it. ByteScout PDF SDK is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout PDF SDK. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Enjoy writing a code with ready-to-use sample codes in VBScript and VB6.

ByteScout PDF SDK free trial version is available on our website. VBScript and VB6 and other programming languages are supported.

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

##### ****VideoAnnotation.vbs:**
    
```
' This example demonstrates how to add a video to PDF document.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add video annotation
Set movie = comHelpers.CreateMovie("sample.avi")
Set movieAnnotation = comHelpers.CreateMovieAnnotation((movie), 20, 20, 320, 240)
movieAnnotation.MovieActivation.ShowControls = True
page1.Annotations.Add(movieAnnotation)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->