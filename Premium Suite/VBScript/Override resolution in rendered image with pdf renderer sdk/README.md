## override resolution in rendered image with pdf renderer sdk in VBScript with ByteScout Premium Suite

### How to apply ByteScout Premium Suite for override resolution in rendered image with pdf renderer sdk in VBScript

This page helps you to learn from code samples for programming in VBScript. ByteScout Premium Suite helps with override resolution in rendered image with pdf renderer sdk in VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

If you want to quickly learn then these fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guideline and the VBScript code below will help you quickly learn override resolution in rendered image with pdf renderer sdk. If you want to know how it works, then this VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it. Check these VBScript sample code examples to see if they acknowledge to your needs and requirements for the project.

Visit our website to get a free trial version of ByteScout Premium Suite. Free trial contains many of source code samples to help you with your VBScript project.

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

##### ****OverrideResolutionInRenderedImage.vbs:**
    
```
' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' Set resolution of rendered images to 300DPI
Set renderingOptions = CreateObject("Bytescout.PDFRenderer.RenderingOptions")
renderingOptions.ResolutionOverride= 300

' Iterate through pages
For i = 0 To renderer.GetPageCount()-1
    ' Generate 800x600 px PNG image
    renderer.Save_4 "image" & i & ".png", 2, i, 600, 800, (renderingOptions)
Next


```

<!-- code block end -->