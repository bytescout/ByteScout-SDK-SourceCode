## How to draw lines and curves in pdf with pdf sdk in VBScript with ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to draw lines and curves in pdf with pdf sdk in VBScript

These source code samples are assembled by their programming language and functions they apply. What is ByteScout PDF Suite? It is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to draw lines and curves in pdf with pdf sdk in your VBScript application.

This prolific sample source code in VBScript for ByteScout PDF Suite contains various functions and other necessary options you should do calling the API to draw lines and curves in pdf with pdf sdk. Follow the instructions from scratch to work and copy the VBScript code. Enjoy writing a code with ready-to-use sample codes in VBScript.

Trial version of ByteScout PDF Suite is available for free. Source code samples are included to help you with your VBScript app.

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