## override resolution in rendered image in VBScript and VB6 with ByteScout PDF Renderer SDK

### override resolution in rendered image in VBScript and VB6

The documentation is designed to help you to implement the features on your side. ByteScout PDF Renderer SDK helps with override resolution in rendered image in VBScript and VB6. ByteScout PDF Renderer SDK is the SDK for rendering of PDF into high-quality thumbnails and images. Includes various functions like batch processing, PNG, TIFF output. Can be used from web and desktop applications.

The SDK samples like this one below explain how to quickly make your application do override resolution in rendered image in VBScript and VB6 with the help of ByteScout PDF Renderer SDK. This VBScript and VB6 sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. Enjoy writing a code with ready-to-use sample VBScript and VB6 codes to add override resolution in rendered image functions using ByteScout PDF Renderer SDK in VBScript and VB6.

Trial version can be downloaded from our website. Source code samples for VBScript and VB6 and documentation are included.

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