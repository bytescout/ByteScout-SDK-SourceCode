## How to convert PDF to 1 bit BMP in VBScript and VB6 and ByteScout PDF Renderer SDK

### How to convert PDF to 1 bit BMP in VBScript and VB6

The coding tutorials are designed to help you test the features without need to write your own code. ByteScout PDF Renderer SDK can convert PDF to 1 bit BMP. It can be used from VBScript and VB6. ByteScout PDF Renderer SDK is the software development kit for rendering of PDF files into high quality images or thumbnails. Various functions are included as well: batch processing, PNG, TIFF output, selection area to render, layers management to render text or images or vectors only. Designed for use from web, desktop and middleware applications.

This rich sample source code in VBScript and VB6 for ByteScout PDF Renderer SDK includes the number of functions and options you should do calling the API to convert PDF to 1 bit BMP. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! You can use these VBScript and VB6 sample examples in one or many applications.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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

' Image format: 0 - BMP; 1 - JPEG; 2 - PNG; 3 - TIFF; 4 - GIF
Dim outputImageFormat
outputImageFormat = 2

' Render PDF document at 96 DPI - default PC display resolution
' To get higher quality output, set 200, 300 or more
Dim renderingResolution
renderingResolution = 96

Set renderingOptions = CreateObject("Bytescout.PDFRenderer.RenderingOptions")
' Set pixel format to 1-bit
renderingOptions.ImageBitsPerPixel = 0 ' 0 - 1-bit; 1 - 8-bit; 2 - 24-bit; 3 - 32-bit

' iterate through pages
For i = 0 To renderer.GetPageCount() - 1
	' Save 1-bit image to file
	renderer.Save_2 "page" & CStr(i) & ".bmp", outputImageFormat, i, renderingResolution, (renderingOptions)
Next


```

<!-- code block end -->