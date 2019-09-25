## How to set text rotation in VBScript and VB6 with ByteScout PDF SDK

### How to code in VBScript and VB6 to set text rotation with this step-by-step tutorial

This sample source code below will demonstrate you how to set text rotation in VBScript and VB6. ByteScout PDF SDK can set text rotation. It can be used from VBScript and VB6. ByteScout PDF SDK is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout PDF SDK. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! Enjoy writing a code with ready-to-use sample VBScript and VB6 codes.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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