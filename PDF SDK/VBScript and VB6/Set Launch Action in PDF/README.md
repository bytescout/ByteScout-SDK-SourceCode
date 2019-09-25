## How to set launch action in PDF in VBScript and VB6 using ByteScout PDF SDK

### How to code in VBScript and VB6 to set launch action in PDF with this step-by-step tutorial

The sample source code below will teach you how to set launch action in PDF in VBScript and VB6. ByteScout PDF SDK is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings. It can set launch action in PDF in VBScript and VB6.

This code snippet below for ByteScout PDF SDK works best when you need to quickly set launch action in PDF in your VBScript and VB6 application. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Enjoy writing a code with ready-to-use sample VBScript and VB6 codes.

You can download free trial version of ByteScout PDF SDK from our website to see and try many others source code samples for VBScript and VB6.

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

##### ****LaunchAction.vbs:**
    
```
' This example demonstrates how to create a button that launches an external resource.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Create button
Set button1 = comHelpers.CreatePushButton(20, 20, 120, 25, "button1")
button1.Caption = "Launch sample.txt"
' Create action that opens an external file
Set launchAction = comHelpers.CreateLaunchAction("sample.txt")
button1.OnActivated = launchAction
page1.Annotations.Add(button1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->    

<!-- code block begin -->

##### ****sample.txt:**
    
```
sample.txt

1234567890
abcdefghijklmnopqrstuvwxyz
```

<!-- code block end -->