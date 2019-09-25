## hide text or vector or image layer in pdf with pdf renderer sdk in VBScript using ByteScout PDF Suite

### Learn hide text or vector or image layer in pdf with pdf renderer sdk in VBScript

ByteScout tutorials describe the stuff for programmers who use VBScript. ByteScout PDF Suite was created to assist hide text or vector or image layer in pdf with pdf renderer sdk in VBScript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

The below SDK samples describe how to quickly make your application do hide text or vector or image layer in pdf with pdf renderer sdk in VBScript with the help of ByteScout PDF Suite. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. Enjoy writing a code with ready-to-use sample VBScript codes to implement hide text or vector or image layer in pdf with pdf renderer sdk using ByteScout PDF Suite.

Trial version can be downloaded from our website for free. It contains this and other source code samples for VBScript.

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