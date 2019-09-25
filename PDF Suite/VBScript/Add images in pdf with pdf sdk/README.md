## How to add images in pdf with pdf sdk in VBScript and ByteScout PDF Suite

### Learn to code in VBScript to add images in pdf with pdf sdk with this step-by-step tutorial

The sample source codes on this page shows how to add images in pdf with pdf sdk in VBScript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript and you can use it to add images in pdf with pdf sdk with VBScript.

The SDK samples given below describe how to quickly make your application do add images in pdf with pdf sdk in VBScript with the help of ByteScout PDF Suite.  Simply copy and paste in your VBScript project or application you and then run your app! Enjoy writing a code with ready-to-use sample codes in VBScript.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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