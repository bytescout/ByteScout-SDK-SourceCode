## How to add images in PDF in VBScript and VB6 and ByteScout PDF SDK

### This tutorial will show how to add images in PDF in VBScript and VB6

The sample source codes on this page shows how to add images in PDF in VBScript and VB6. What is ByteScout PDF SDK? It is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings. It can help you to add images in PDF in your VBScript and VB6 application.

Fast application programming interfaces of ByteScout PDF SDK for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to add images in PDF. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! Implementing VBScript and VB6 application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

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

##### ****Images.vbs:**
    
```
' This example demonstrates how to add images of various formats. 

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Add JPEG image and draw unscaled
Set image1 = comHelpers.CreateImage("Image1.jpg")
canvas.DrawImage (image1), 20, 20

' Add PNG image and draw reduced twice
Set image2 = comHelpers.CreateImage("Image2.png")
canvas.DrawImage_2 (image2), 20, 520, image2.Width / 2, image2.Height / 2

' Add TIFF image and draw scaled disproportionately
Set image3 = comHelpers.CreateImage("Image3.tif")
canvas.DrawImage_2 (image3), 270, 520, image3.Width / 2, image3.Height / 4

' Add GIF image and draw rotated 90 degrees and scaled
Set image4 = comHelpers.CreateImage("Image4.gif")
canvas.TranslateTransform 390, 650
canvas.RotateTransform 90
canvas.DrawImage_2 (image4), 0, 0, image4.Width / 4, image4.Height / 4

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->