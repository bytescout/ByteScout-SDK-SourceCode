## override resolution in multipage tiff with pdf renderer sdk in VBScript using ByteScout PDF Suite

### How to apply ByteScout PDF Suite for override resolution in multipage tiff with pdf renderer sdk in VBScript

We regularly create and update our sample code library so you may quickly learn override resolution in multipage tiff with pdf renderer sdk and the step-by-step process in VBScript. ByteScout PDF Suite helps with override resolution in multipage tiff with pdf renderer sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

VBScript code snippet like this for ByteScout PDF Suite works best when you need to quickly implement override resolution in multipage tiff with pdf renderer sdk in your VBScript application. To use override resolution in multipage tiff with pdf renderer sdk in your VBScript project or application just copy & paste the code and then run your app! Further improvement of the code will make it more robust.

Trial version along with the source code samples for VBScript can be downloaded from our website

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