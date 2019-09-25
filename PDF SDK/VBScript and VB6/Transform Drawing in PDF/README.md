## transform drawing in PDF in VBScript and VB6 with ByteScout PDF SDK

### transform drawing in PDF in VBScript and VB6

Writing of the code to transform drawing in PDF in VBScript and VB6 can be done by developers of any level using ByteScout PDF SDK. Transform drawing in PDF in VBScript and VB6 can be implemented with ByteScout PDF SDK. ByteScout PDF SDK is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. Follow the instruction from the scratch to work and copy and paste code for VBScript and VB6 into your editor. Code testing will allow the function to be tested and work properly with your data.

ByteScout PDF SDK free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

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

##### ****Transformations.vbs:**
    
```
' This example demonstrates how to use coordinate space transformations.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Prepare pens
Set blackPen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 0), 2.0)
blackPen.Opacity = 50
Set bluePen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 255), 2.0)
bluePen.Opacity = 50
Set greenPen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 255, 0), 2.0)
greenPen.Opacity = 50

' Move coordinate space zero point to (200, 200) and draw a rectangle of 50x50 dize
canvas.TranslateTransform 200, 200
canvas.DrawRectangle (blackPen), 0, 0, 50, 50

' Now zoom the coordinate space in twice and draw the same rectangle in green
canvas.ScaleTransform 2, 2
canvas.DrawRectangle (greenPen), 0, 0, 50, 50

' Now rotate the coordinate space by 30 degrees and draw the same rectangle in blue
canvas.RotateTransform 30
canvas.DrawRectangle (bluePen), 0, 0, 50, 50

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->