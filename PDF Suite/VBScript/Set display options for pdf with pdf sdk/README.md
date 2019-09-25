## How to set display options for pdf with pdf sdk in VBScript with ByteScout PDF Suite

### Learn to set display options for pdf with pdf sdk in VBScript

The sample source code below will teach you how to set display options for pdf with pdf sdk in VBScript. ByteScout PDF Suite can set display options for pdf with pdf sdk. It can be applied from VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

This prolific sample source code in VBScript for ByteScout PDF Suite contains various functions and other necessary options you should do calling the API to set display options for pdf with pdf sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample VBScript codes.

ByteScout PDF Suite free trial version is available on our website. VBScript and other programming languages are supported.

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

##### ****DisplayOptions.vbs:**
    
```
' This example demonstrates how to set display options for a viewer application.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Set page mode (which panels should be shown at viewing application start)
pdfDocument.PageMode = comHelpers.PAGEMODE_THUMBNAIL ' show thumbnails panel

' Show/hide various interface elements
pdfDocument.ViewerPreferences.CenterWindow = True
pdfDocument.ViewerPreferences.FitWindow = True
pdfDocument.ViewerPreferences.HideMenubar = True
pdfDocument.ViewerPreferences.HideToolbar = True
pdfDocument.ViewerPreferences.HideWindowUI = False

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->