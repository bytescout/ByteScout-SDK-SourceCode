## How to use blend mode for drawing in PDF in VBScript and VB6 with ByteScout PDF SDK

### This code in VBScript and VB6 shows how to use blend mode for drawing in PDF with this how to tutorial

ByteScout tutorials are designed to explain the code for both VBScript and VB6 beginners and advanced programmers. ByteScout PDF SDK can use blend mode for drawing in PDF. It can be used from VBScript and VB6. ByteScout PDF SDK is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

Fast application programming interfaces of ByteScout PDF SDK for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to use blend mode for drawing in PDF. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. Detailed tutorials and documentation are available along with installed ByteScout PDF SDK if you'd like to dive deeper into the topic and the details of the API.

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

##### ****BlendMode.vbs:**
    
```
' This example demonstrates how to use blend modes - a way how 
' intersecting semi-transparent objects will blend on page canvas.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Create transparent brushes
Set brushRed = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
brushRed.Opacity = 50
Set brushGreen = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 255, 0))
brushGreen.Opacity = 50
Set brushBlue = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255))
brushBlue.Opacity = 50

' Normal blending
canvas.BlendMode = comHelpers.BLENDMODE_NORMAL
canvas.DrawCircle_2 (brushRed), 100, 100, 50
canvas.DrawCircle_2 (brushGreen), 100, 150, 50
canvas.DrawCircle_2 (brushBlue), 150, 100, 50

' Darken blending
canvas.BlendMode = comHelpers.BLENDMODE_DARKEN
canvas.DrawCircle_2 (brushRed), 300, 100, 50
canvas.DrawCircle_2 (brushGreen), 300, 150, 50
canvas.DrawCircle_2 (brushBlue), 350, 100, 50

' Lighten blending
canvas.BlendMode = comHelpers.BLENDMODE_LIGHTEN
canvas.DrawCircle_2 (brushRed), 100, 300, 50
canvas.DrawCircle_2 (brushGreen), 100, 350, 50
canvas.DrawCircle_2 (brushBlue), 150, 300, 50

' Color burn blending
canvas.BlendMode = comHelpers.BLENDMODE_COLORBURN
canvas.DrawCircle_2 (brushRed), 300, 300, 50
canvas.DrawCircle_2 (brushGreen), 300, 350, 50
canvas.DrawCircle_2 (brushBlue), 350, 300, 50

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->