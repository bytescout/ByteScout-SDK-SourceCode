## How to add watermarks in pdf with pdf sdk in VBScript using ByteScout Premium Suite

### Learn to add watermarks in pdf with pdf sdk in VBScript

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to add watermarks in pdf with pdf sdk with VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guidelines and the code below will help you quickly learn how to add watermarks in pdf with pdf sdk.  Simply copy and paste in your VBScript project or application you and then run your app! Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

ByteScout Premium Suite free trial version is available on our website. VBScript and other programming languages are supported.

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