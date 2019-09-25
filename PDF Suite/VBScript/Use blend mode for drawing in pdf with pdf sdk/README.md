## How to use blend mode for drawing in pdf with pdf sdk in VBScript and ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to use blend mode for drawing in pdf with pdf sdk in VBScript

These sample source codes on this page below are displaying how to use blend mode for drawing in pdf with pdf sdk in VBScript. Want to use blend mode for drawing in pdf with pdf sdk in your VBScript app? ByteScout PDF Suite is designed for it. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

This prolific sample source code in VBScript for ByteScout PDF Suite contains various functions and other necessary options you should do calling the API to use blend mode for drawing in pdf with pdf sdk. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample codes in VBScript.

Trial version of ByteScout PDF Suite is available for free. Source code samples are included to help you with your VBScript app.

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