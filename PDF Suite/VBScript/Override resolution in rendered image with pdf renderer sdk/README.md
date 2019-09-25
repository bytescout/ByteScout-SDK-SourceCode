## override resolution in rendered image with pdf renderer sdk in VBScript using ByteScout PDF Suite

### How to apply ByteScout PDF Suite for override resolution in rendered image with pdf renderer sdk in VBScript

The documentation is crafted to assist you to apply the features on your side easily. ByteScout PDF Suite was created to assist override resolution in rendered image with pdf renderer sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

This rich and prolific sample source code in VBScript for ByteScout PDF Suite contains various functions and options you should do calling the API to implement override resolution in rendered image with pdf renderer sdk. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample VBScript codes to implement override resolution in rendered image with pdf renderer sdk using ByteScout PDF Suite.

Our website gives free trial version of ByteScout PDF Suite. It includes all these source code samples with the purpose to assist you with your VBScript application implementation.

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