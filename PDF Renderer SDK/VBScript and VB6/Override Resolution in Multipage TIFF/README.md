## override resolution in multipage TIFF in VBScript and VB6 with ByteScout PDF Renderer SDK

### How to code override resolution in multipage TIFF in VBScript and VB6: How-To tutorial

Writing of the code to override resolution in multipage TIFF in VBScript and VB6 can be done by developers of any level using ByteScout PDF Renderer SDK. ByteScout PDF Renderer SDK was made to help with override resolution in multipage TIFF in VBScript and VB6. ByteScout PDF Renderer SDK is the SDK for rendering of PDF into high-quality thumbnails and images. Includes various functions like batch processing, PNG, TIFF output. Can be used from web and desktop applications.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample VBScript and VB6 codes to add override resolution in multipage TIFF functions using ByteScout PDF Renderer SDK in VBScript and VB6.

Visit our website provides for free trial version of ByteScout PDF Renderer SDK. Free trial includes lots of source code samples to help you with your VBScript and VB6 project.

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

##### ****OverrideResolutionInMultipageTIFF.vbs:**
    
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

' Generate 800x600 px multipage TIFF
renderer.SaveMultipageTiff_4 "result.tif", 0, -1, 600, 800, (renderingOptions)


```

<!-- code block end -->