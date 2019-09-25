## How to convert PDF to high quality PNG in VBScript and VB6 with ByteScout PDF Renderer SDK

### This tutorial will show how to convert PDF to high quality PNG in VBScript and VB6

ByteScout tutorials are designed to explain the code for both VBScript and VB6 beginners and advanced programmers. ByteScout PDF Renderer SDK is the library that renders PDF into high quality images and thumbnails. Includes various functions like batch processing, PNG, TIFF output. Can be used from web and desktop applications and you can use it to convert PDF to high quality PNG with VBScript and VB6.

You will save a lot of time on writing and testing code as you may just take the VBScript and VB6 code from ByteScout PDF Renderer SDK for convert PDF to high quality PNG below and use it in your application. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Implementing VBScript and VB6 application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

ByteScout PDF Renderer SDK free trial version is available on our website. VBScript and VB6 and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Renderer%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Renderer%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=eenhl7106lA](https://www.youtube.com/watch?v=eenhl7106lA)




<!-- code block begin -->

##### ****PDFToPNG.vbs:**
    
```
' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' Render PDF document at 600 DPI for higher quality
Dim renderingResolution
renderingResolution = 600

' Image format: 0 - BMP; 1 - JPEG; 2 - PNG; 3 - TIFF; 4 - GIF
Dim outputImageFormat
outputImageFormat = 2

' Iterate through pages
For pageIndex = 0 To renderer.GetPageCount() - 1
	' Render document page to PNG image file
	renderer.Save "page" & CStr(pageIndex) & ".png", outputImageFormat, pageIndex, renderingResolution
Next



```

<!-- code block end -->