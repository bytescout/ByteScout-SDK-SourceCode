## How to convert PDF to multipage TIFF in VBScript and VB6 and ByteScout PDF Renderer SDK

### How to convert PDF to multipage TIFF in VBScript and VB6

The sample source codes on this page shows how to convert PDF to multipage TIFF in VBScript and VB6. ByteScout PDF Renderer SDK is the library that renders PDF into high quality images and thumbnails. Includes various functions like batch processing, PNG, TIFF output. Can be used from web and desktop applications. It can be used to convert PDF to multipage TIFF using VBScript and VB6.

Fast application programming interfaces of ByteScout PDF Renderer SDK for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to convert PDF to multipage TIFF. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! Use of ByteScout PDF Renderer SDK in VBScript and VB6 is also explained in the documentation included along with the product.

Our website provides trial version of ByteScout PDF Renderer SDK for free. It also includes documentation and source code samples.

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

##### ****PDFToTIFF.vbs:**
    
```
' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' Render PDF document at 96 DPI - default PC display resolution
' To get higher quality output, set 200, 300 or more
Dim renderingResolution
renderingResolution = 96

Set renderingOptions = CreateObject("Bytescout.PDFRenderer.RenderingOptions")
' Set TIFF compression to CCITT4 
renderingOptions.TIFFCompression = 3  ' 1 - LZW; 2 - CCIT3; 3 - CCIT4; 4 - JPEG; 5 - RLE

' save to multi-page TIFF
renderer.SaveMultipageTiff_2 "multipage.tiff", 0, -1, renderingResolution, (renderingOptions)


```

<!-- code block end -->