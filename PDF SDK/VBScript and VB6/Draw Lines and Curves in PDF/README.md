## How to draw lines and curves in PDF in VBScript and VB6 with ByteScout PDF SDK

### This code in VBScript and VB6 shows how to draw lines and curves in PDF with this how to tutorial

These source code samples are listed and grouped by their programming language and functions they use. ByteScout PDF SDK is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms. It can draw lines and curves in PDF in VBScript and VB6.

Fast application programming interfaces of ByteScout PDF SDK for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to draw lines and curves in PDF. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. Enjoy writing a code with ready-to-use sample codes in VBScript and VB6.

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

##### ****LinesAndCurves.vbs:**
    
```
' This example demonstrates how to draw lines and curves.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

Set blackPen = comHelpers.CreateSolidPen(comHelpers.CreateColorGray(0), 1)
Set dashedPen = comHelpers.CreateSolidPen(comHelpers.CreateColorGray(0), 1)
dashedPen.DashPattern = comHelpers.CreateDashPattern(Array(2.0, 2.0), 0)

' Draw dashed lines
canvas.DrawLine (dashedPen), 100, 100, 200, 100
canvas.DrawLine (dashedPen), 200, 100, 200, 200
canvas.DrawLine (dashedPen), 200, 200, 100, 200
' Draw besier curve by the same points
canvas.DrawCurve (blackPen), 100, 100, 200, 100, 200, 200, 100, 200

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->