## How to draw rectangles in pdf with pdf sdk in VBScript using ByteScout PDF Suite

### Learn to code in VBScript to draw rectangles in pdf with pdf sdk with this step-by-step tutorial

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout PDF Suite: the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can draw rectangles in pdf with pdf sdk in VBScript.

This prolific sample source code in VBScript for ByteScout PDF Suite contains various functions and other necessary options you should do calling the API to draw rectangles in pdf with pdf sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Want to see how it works with your data then code testing will allow the function to be tested and work properly.

The trial version of ByteScout PDF Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****Rectangles.vbs:**
    
```
' This example demonstrates how to draw rectangles.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Prepare pens and brushes
Set borderPen = comHelpers.CreateSolidPen(comHelpers.CreateColorGray(128), 2.0)
Set brush1 = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
Set brush2 = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 255, 255))

' Draw transparent rectangle with border only
canvas.DrawRectangle (borderPen), 100, 100, 100, 50

' Draw rounded rectangle with broder and filling
canvas.DrawRoundedRectangle_3 (borderPen), (brush1), 250, 100, 100, 50, 10

' Draw rectangle as polygon
Set pointsArray = comHelpers.CreatePointsArray(Array(Array(400, 100), Array(500, 100), Array(500, 150), Array(400, 150)))
canvas.DrawPolygon_3 (borderPen), (brush2), (pointsArray)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->