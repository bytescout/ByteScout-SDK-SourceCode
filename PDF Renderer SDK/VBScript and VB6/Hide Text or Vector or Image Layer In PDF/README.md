## hide text or vector or image layer in PDF in VBScript and VB6 using ByteScout PDF Renderer SDK

### Make hide text or vector or image layer in PDF in VBScript and VB6: ### Tutorial on how to do hide text or vector or image layer in PDF in VBScript and VB6

These source code samples are listed and grouped by their programming language and functions they use. ByteScout PDF Renderer SDK was made to help with hide text or vector or image layer in PDF in VBScript and VB6. ByteScout PDF Renderer SDK is the component (SDK) that renders PDF into high quality images and thumbnails. Includes various functions like page by page processing, BMP, PNG, TIFF or stream output. Can be used from web and desktop applications.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. VBScript and VB6 sample code is all you need: copy and paste the code to your VBScript and VB6 application's code editor, add a reference to ByteScout PDF Renderer SDK (if you haven't added yet) and you are ready to go! Enjoy writing a code with ready-to-use sample VBScript and VB6 codes to add hide text or vector or image layer in PDF functions using ByteScout PDF Renderer SDK in VBScript and VB6.

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

##### ****PDFToPNG.vbs:**
    
```
' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

Set renderingOptions = CreateObject("Bytescout.PDFRenderer.RenderingOptions")

' Enable text objects rendering
renderingOptions.RenderTextObjects = True
' DISABLE vector objects rendering
renderingOptions.RenderVectorObjects = False
' DISABLE image objects rendering
renderingOptions.RenderImageObjects = False
        
' Render PDF document at 96 DPI - default PC display resolution
' To get higher quality output, set 200, 300 or more
Dim renderingResolution
renderingResolution = 96

' iterate through pages
For i=0 To renderer.GetPageCount()-1
	' Render document page to PNG image file
    renderer.Save_2 "image" & i & ".png", 2, i, renderingResolution, (renderingOptions)
Next


```

<!-- code block end -->