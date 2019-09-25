## How to convert PDF to EMF in VBScript and VB6 with ByteScout PDF Renderer SDK

### This code in VBScript and VB6 shows how to convert PDF to EMF with this how to tutorial

On this page you will learn from code samples for programming in VBScript and VB6.Writing of the code to convert PDF to EMF in VBScript and VB6 can be done by developers of any level using ByteScout PDF Renderer SDK. ByteScout PDF Renderer SDK can convert PDF to EMF. It can be used from VBScript and VB6. ByteScout PDF Renderer SDK is the component (SDK) that renders PDF into high quality images and thumbnails. Includes various functions like page by page processing, BMP, PNG, TIFF or stream output. Can be used from web and desktop applications.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout PDF Renderer SDK. In order to implement the functionality, you should copy and paste this code for VBScript and VB6 below into your code editor with your app, compile and run your application. You can use these VBScript and VB6 sample examples in one or many applications.

Free trial version of ByteScout PDF Renderer SDK is available for download from our website. Get it to try other source code samples for VBScript and VB6.

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

##### ****PDFToEmf.vbs:**
    
```
' Create Bytescout.PDFRenderer.VectorRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.VectorRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' iterate through pages
For i = 0 To renderer.GetPageCount() - 1

	' Render document page to EMF image file
    renderer.Save "image" & i & ".emf", i, 300

Next



```

<!-- code block end -->