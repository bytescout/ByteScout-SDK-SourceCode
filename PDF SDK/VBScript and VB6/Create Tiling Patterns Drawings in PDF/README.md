## How to create tiling patterns drawings in PDF in VBScript and VB6 with ByteScout PDF SDK

### The tutorial shows how to create tiling patterns drawings in PDF in VBScript and VB6

This sample source code below will demonstrate you how to create tiling patterns drawings in PDF in VBScript and VB6. What is ByteScout PDF SDK? It is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings. It can help you to create tiling patterns drawings in PDF in your VBScript and VB6 application.

Fast application programming interfaces of ByteScout PDF SDK for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to create tiling patterns drawings in PDF. In order to implement the functionality, you should copy and paste this code for VBScript and VB6 below into your code editor with your app, compile and run your application. Code testing will allow the function to be tested and work properly with your data.

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

##### ****TilingPatterns.vbs:**
    
```
' This example demonstrates how to use tiling patterns.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set blueColor = comHelpers.CreateColorRGB(0, 0, 255)
Set grayColor = comHelpers.CreateColorGray(128)
Set blackColor = comHelpers.CreateColorGray(0)

' Create tiling brush and paint on it 
Set tilingBrush1 = comHelpers.CreateUncoloredTilingBrush(10, 12)
Set brushCanvas = tilingBrush1.Canvas
brushCanvas.DrawCircle comHelpers.CreateSolidPen((blueColor), 1), 0, 6, 6
tilingBrush1.Color = blueColor

' Create second tiling brush and paint on it using the first brush
Set tilingBrush2 = comHelpers.CreateColoredTilingBrush(70, 50)
Set brushCanvas = tilingBrush2.Canvas
brushCanvas.DrawEllipse_3 comHelpers.CreateSolidPen((grayColor), 1), (tilingBrush1), 0, 0, 60, 20

' Draw rectangle and fill it with combined tiling brush
page1.Canvas.DrawRectangle_3 comHelpers.CreateSolidPen((blackColor), 1), (tilingBrush2), 100, 100, 400, 400

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->