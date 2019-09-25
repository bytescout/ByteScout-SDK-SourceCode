## How to convert PDF to BMP in VBScript and VB6 using ByteScout PDF Renderer SDK

### The tutorial shows how to convert PDF to BMP in VBScript and VB6

This sample source code below will demonstrate you how to convert PDF to BMP in VBScript and VB6. ByteScout PDF Renderer SDK can convert PDF to BMP. It can be used from VBScript and VB6. ByteScout PDF Renderer SDK is the library that renders PDF into high quality images and thumbnails. Includes various functions like batch processing, PNG, TIFF output. Can be used from web and desktop applications.

The SDK samples like this one below explain how to quickly make your application do convert PDF to BMP in VBScript and VB6 with the help of ByteScout PDF Renderer SDK. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! Code testing will allow the function to be tested and work properly with your data.

Free trial version of ByteScout PDF Renderer SDK is available for download from our website. Get it to try other source code samples for VBScript and VB6.

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

##### ****PDFToBmp.vbs:**
    
```
' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' Render PDF document at 96 DPI - default PC display resolution
' To get higher quality output, set 200, 300 or more
Dim renderingResolution
renderingResolution = 96

' Image format: 0 - BMP; 1 - JPEG; 2 - PNG; 3 - TIFF; 4 - GIF
Dim outputImageFormat
outputImageFormat = 0

' Iterate through pages
For i = 0 To renderer.GetPageCount() - 1
	' Rendered page to file
	renderer.Save "page" & CStr(i) & ".bmp", outputImageFormat, i, renderingResolution
Next


```

<!-- code block end -->