## How to set text rotation with pdf sdk in VBScript and ByteScout PDF Suite

### Learn to set text rotation with pdf sdk in VBScript

Set text rotation with pdf sdk is simple to apply in VBScript if you use these source codes below. Want to set text rotation with pdf sdk in your VBScript app? ByteScout PDF Suite is designed for it. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

The SDK samples given below describe how to quickly make your application do set text rotation with pdf sdk in VBScript with the help of ByteScout PDF Suite. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! This basic programming language sample code for VBScript will do the whole work for you to set text rotation with pdf sdk.

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

##### ****TextRotation.vbs:**
    
```
' This example demonstrates how to draw a text.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Prepare font and brush
Set font = comHelpers.CreateSystemFont("Arial", 24)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

Set canvas = page1.Canvas

' Draw simple text
canvas.DrawString "Simple text.", (font), (blackBrush), 50, 100

' Save canvas state
canvas.SaveGraphicsState()

' Move canvas origin (0,0) point to (50,100)
canvas.TranslateTransform 50, 100

' Rotate canvas at 45 deg around of the origin point
canvas.RotateTransform 45 
canvas.DrawString "Rotated 45", (font), (blackBrush), 0, 0

' Rotate another 45 deg
canvas.RotateTransform 45 
canvas.DrawString "Rotated 90", (font), (blackBrush), 0, 0

' Restore canvas state to reset all transformations
canvas.RestoreGraphicsState()

' Save document
pdfDocument.Save("result.pdf")


' Save document to file
pdfDocument.Save("result.pdf")

' Open PDF document in default associated application (for demo puprpose)
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->