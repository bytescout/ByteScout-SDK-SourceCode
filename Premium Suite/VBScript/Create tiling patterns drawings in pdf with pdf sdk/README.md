## How to create tiling patterns drawings in pdf with pdf sdk in VBScript using ByteScout Premium Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to create tiling patterns drawings in pdf with pdf sdk in VBScript

These source code samples are assembled by their programming language and functions they apply. ByteScout Premium Suite can create tiling patterns drawings in pdf with pdf sdk. It can be applied from VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

The SDK samples given below describe how to quickly make your application do create tiling patterns drawings in pdf with pdf sdk in VBScript with the help of ByteScout Premium Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Further improvement of the code will make it more robust.

You can download free trial version of ByteScout Premium Suite from our website to see and try many others source code samples for VBScript.

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