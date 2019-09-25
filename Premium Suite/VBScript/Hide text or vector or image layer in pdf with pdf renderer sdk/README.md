## hide text or vector or image layer in pdf with pdf renderer sdk in VBScript using ByteScout Premium Suite

### Learn to code hide text or vector or image layer in pdf with pdf renderer sdk in VBScript: How-To tutorial

Every ByteScout tool includes sampleVBScript source codes that you can find here or in the folder with installed ByteScout product. ByteScout Premium Suite helps with hide text or vector or image layer in pdf with pdf renderer sdk in VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 Want to speed up the application development? Then this VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout Premium Suite. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. Enjoy writing a code with ready-to-use sample VBScript codes to add hide text or vector or image layer in pdf with pdf renderer sdk functions using ByteScout Premium Suite in VBScript.

 If you want to try other samples for VBScript then free trial version of ByteScout Premium Suite is available on our website.

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