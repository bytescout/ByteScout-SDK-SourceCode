## How to draw lines and curves in pdf with pdf sdk in VBScript and ByteScout Premium Suite

### Learn to draw lines and curves in pdf with pdf sdk in VBScript

An easy to understand sample source code to learn how to draw lines and curves in pdf with pdf sdk in VBScript ByteScout Premium Suite: the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can draw lines and curves in pdf with pdf sdk in VBScript.

The SDK samples given below describe how to quickly make your application do draw lines and curves in pdf with pdf sdk in VBScript with the help of ByteScout Premium Suite. Follow the instructions from scratch to work and copy the VBScript code. Further improvement of the code will make it more robust.

Our website gives trial version of ByteScout Premium Suite for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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