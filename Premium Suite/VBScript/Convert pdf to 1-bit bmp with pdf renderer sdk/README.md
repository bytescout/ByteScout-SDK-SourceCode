## How to convert pdf to 1 bit bmp with pdf renderer sdk in VBScript using ByteScout Premium Suite

### Learn to code in VBScript to convert pdf to 1 bit bmp with pdf renderer sdk with this step-by-step tutorial

These source code samples are assembled by their programming language and functions they apply. What is ByteScout Premium Suite? It is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to convert pdf to 1 bit bmp with pdf renderer sdk in your VBScript application.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Premium Suite for convert pdf to 1 bit bmp with pdf renderer sdk below and use it in your application. Just copy and paste the code into your VBScript application’s code and follow the instructions. Want to see how it works with your data then code testing will allow the function to be tested and work properly.

ByteScout provides the free trial version of ByteScout Premium Suite along with the documentation and source code samples.

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