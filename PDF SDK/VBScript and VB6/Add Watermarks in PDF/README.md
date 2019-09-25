## How to add watermarks in PDF in VBScript and VB6 with ByteScout PDF SDK

### How to code in VBScript and VB6 to add watermarks in PDF with this step-by-step tutorial

Sample source code below will show you how to cope with a difficult task like add watermarks in PDF in VBScript and VB6. Want to add watermarks in PDF in your VBScript and VB6 app? ByteScout PDF SDK is designed for it. ByteScout PDF SDK is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

This code snippet below for ByteScout PDF SDK works best when you need to quickly add watermarks in PDF in your VBScript and VB6 application. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! You can use these VBScript and VB6 sample examples in one or many applications.

Download free trial version of ByteScout PDF SDK from our website with this and other source code samples for VBScript and VB6.

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

##### ****Watermarks.vbs:**
    
```
' This example demonstrates how to change the word spacing.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add pages
pdfDocument.Pages.Add(comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4))
pdfDocument.Pages.Add(comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4))
pdfDocument.Pages.Add(comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4))

Set font1 = comHelpers.CreateSystemFont("Times New Roman", 16)
Set font2 = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_HELVETICABOLD, 24)

Set semitransparentRedBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
semitransparentRedBrush.Opacity = 50 ' make the brush semitransparent
Set greenBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 128, 0))
Set semitransparentBlueBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255))
semitransparentBlueBrush.Opacity = 50 ' make the brush semitransparent
Set redPen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(255, 0, 0), 1)

' Add tiling watermark
Set watermark1 = comHelpers.CreateTextWatermark("Tiling Watermark")
watermark1.WatermarkLocation = comHelpers.TEXTWATERMARKLOCATION_TILED
watermark1.Angle = 30
watermark1.Brush = semitransparentBlueBrush
pdfDocument.Watermarks.Add(watermark1)

' Add autosized watermark to every page of the document
Set watermark2 = comHelpers.CreateTextWatermark("Center Watermark")
watermark2.WatermarkLocation = comHelpers.TEXTWATERMARKLOCATION_DIAGONALFROMBOTTOMLEFTTOTOPRIGHT
watermark2.Font = font1
watermark2.Brush = semitransparentRedBrush
watermark2.Pen = redPen
pdfDocument.Watermarks.Add(watermark2)

' Add watermark of custom size and location to the first page only
Set watermark3 = comHelpers.CreateTextWatermark("Simple Watermark")
watermark3.Font = font2
watermark3.Brush = greenBrush
watermark3.Left = 350
watermark3.Top = 800
pdfDocument.Pages.Item(0).Watermarks.Add(watermark3)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->