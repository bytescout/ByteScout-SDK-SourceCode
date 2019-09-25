## How to create tiling patterns drawings in pdf with pdf sdk in VBScript and ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to create tiling patterns drawings in pdf with pdf sdk in VBScript

The code displayed below will guide you to install an VBScript app to create tiling patterns drawings in pdf with pdf sdk. ByteScout PDF Suite can create tiling patterns drawings in pdf with pdf sdk. It can be applied from VBScript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

The SDK samples given below describe how to quickly make your application do create tiling patterns drawings in pdf with pdf sdk in VBScript with the help of ByteScout PDF Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. If you want to use these VBScript sample examples in one or many applications then they can be used easily.

Our website gives trial version of ByteScout PDF Suite for free. It also includes documentation and source code samples.

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