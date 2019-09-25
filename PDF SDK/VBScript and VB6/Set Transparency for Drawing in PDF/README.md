## How to set transparency for drawing in PDF in VBScript and VB6 with ByteScout PDF SDK

### How to set transparency for drawing in PDF in VBScript and VB6

The sample source codes on this page shows how to set transparency for drawing in PDF in VBScript and VB6. ByteScout PDF SDK is the SDK for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings. It can set transparency for drawing in PDF in VBScript and VB6.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout PDF SDK. In order to implement the functionality, you should copy and paste this code for VBScript and VB6 below into your code editor with your app, compile and run your application. Use of ByteScout PDF SDK in VBScript and VB6 is also explained in the documentation included along with the product.

Free trial version of ByteScout PDF SDK is available on our website. Documentation and source code samples are included.

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

##### ****Transparency.vbs:**
    
```
' This example demonstrates how to draw transparent objects.

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
Set borderPen = comHelpers.CreateSolidPen(comHelpers.CreateColorGray(0), 2.0)

Set brush1 = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
Set brush2 = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255))

borderPen.Opacity = 50
brush1.Opacity = 30
brush2.Opacity = 60

' Draw normal rectangles
canvas.DrawRectangle_2 (brush1), 100, 100, 100, 100
canvas.DrawRectangle_3 (borderPen), (brush2), 150, 150, 100, 100

borderPen.Opacity = 80
brush1.Opacity = 60
brush2.Opacity = 30

' Draw rounded rectangles
canvas.DrawRoundedRectangle_2 (brush1), 220, 100, 100, 100, 10
canvas.DrawRoundedRectangle_3 (borderPen), (brush2), 270, 150, 100, 100, 10

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->