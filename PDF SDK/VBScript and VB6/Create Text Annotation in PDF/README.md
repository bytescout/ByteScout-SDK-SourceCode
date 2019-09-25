## How to create text annotation in PDF in VBScript and VB6 and ByteScout PDF SDK

### How to create text annotation in PDF in VBScript and VB6

This sample source code below will demonstrate you how to create text annotation in PDF in VBScript and VB6. ByteScout PDF SDK: the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings. It can create text annotation in PDF in VBScript and VB6.

This rich sample source code in VBScript and VB6 for ByteScout PDF SDK includes the number of functions and options you should do calling the API to create text annotation in PDF. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. You can use these VBScript and VB6 sample examples in one or many applications.

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

##### ****TextAnnotation.vbs:**
    
```
' This example demonstrates how to add a text annotation.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add collapsed annotation (shown as a tooltip when mouse is over the icon)
Set collapsedAnnotation = comHelpers.CreateTextAnnotation(20, 20)
collapsedAnnotation.Color = comHelpers.CreateColorRGB(255, 255, 0)
collapsedAnnotation.Icon = comHelpers.TEXTANNOTATIONICON_COMMENT
collapsedAnnotation.Author = "Mr. Important"
collapsedAnnotation.Contents = "The quick brown fox jumps over the lazy dog."
page1.Annotations.Add(collapsedAnnotation)

' Add expanded annotation
Set expandedAnnotation = comHelpers.CreateTextAnnotation(20, 50)
expandedAnnotation.Color = comHelpers.CreateColorRGB(255, 0, 0)
expandedAnnotation.Icon = comHelpers.TEXTANNOTATIONICON_NOTE
expandedAnnotation.Open = True
expandedAnnotation.Author = "John Doe"
expandedAnnotation.Contents = "The quick brown fox jumps over the lazy dog."
page1.Annotations.Add(expandedAnnotation)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->