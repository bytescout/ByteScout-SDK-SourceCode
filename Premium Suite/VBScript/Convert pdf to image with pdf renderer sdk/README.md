## How to convert pdf to image with pdf renderer sdk in VBScript using ByteScout Premium Suite

### Learn to code in VBScript to convert pdf to image with pdf renderer sdk with this step-by-step tutorial

Quickly learn how to convert pdf to image with pdf renderer sdk in VBScript with this sample source code. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to convert pdf to image with pdf renderer sdk with VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Premium Suite for convert pdf to image with pdf renderer sdk below and use it in your application.  Simply copy and paste in your VBScript project or application you and then run your app! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

You can download free trial version of ByteScout Premium Suite from our website to see and try many others source code samples for VBScript.

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