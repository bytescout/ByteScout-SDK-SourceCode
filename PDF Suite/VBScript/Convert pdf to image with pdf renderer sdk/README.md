## How to convert pdf to image with pdf renderer sdk in VBScript and ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to convert pdf to image with pdf renderer sdk in VBScript

The code displayed below will guide you to install an VBScript app to convert pdf to image with pdf renderer sdk. Want to convert pdf to image with pdf renderer sdk in your VBScript app? ByteScout PDF Suite is designed for it. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for convert pdf to image with pdf renderer sdk below and use it in your application. Follow the instructions from scratch to work and copy the VBScript code. Enjoy writing a code with ready-to-use sample codes in VBScript.

ByteScout PDF Suite free trial version is available on our website. VBScript and other programming languages are supported.

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

##### ****PDFToImage.vbs:**
    
```
' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' Image format: 0 - BMP; 1 - JPEG; 2 - PNG; 3 - TIFF; 4 - GIF
Dim outputImageFormat
outputImageFormat = 1

' Output extension
Dim outputExtension
Select Case outputImageFormat
Case 0
outputExtension =".bmp"
Case 1
outputExtension =".jpg"
Case 2
outputExtension =".png"
Case 3
outputExtension =".tiff"
Case Else
outputExtension =".gif"
End Select

' Specify Image output's Width and Height
Dim Width
Dim Height

Width = 600
Height = 800

' Iterate through pages
For pageIndex = 0 To renderer.GetPageCount() - 1
	' Render document page to image file
	renderer.Save_3 "page" & CStr(pageIndex) & outputExtension, outputImageFormat, pageIndex, Width, Height
Next



```

<!-- code block end -->