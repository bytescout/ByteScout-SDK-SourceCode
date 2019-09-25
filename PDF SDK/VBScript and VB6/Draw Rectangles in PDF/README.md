## How to draw rectangles in PDF in VBScript and VB6 and ByteScout PDF SDK

### Write code in VBScript and VB6 to draw rectangles in PDF with this step-by-step tutorial

The sample source codes on this page shows how to draw rectangles in PDF in VBScript and VB6. ByteScout PDF SDK: the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings. It can draw rectangles in PDF in VBScript and VB6.

This rich sample source code in VBScript and VB6 for ByteScout PDF SDK includes the number of functions and options you should do calling the API to draw rectangles in PDF. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! Implementing VBScript and VB6 application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

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