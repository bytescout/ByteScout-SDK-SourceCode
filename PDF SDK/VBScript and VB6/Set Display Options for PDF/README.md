## How to set display options for PDF in VBScript and VB6 and ByteScout PDF SDK

### The tutorial below will demonstrate how to set display options for PDF in VBScript and VB6

This sample source code below will demonstrate you how to set display options for PDF in VBScript and VB6. What is ByteScout PDF SDK? It is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms. It can help you to set display options for PDF in your VBScript and VB6 application.

The SDK samples like this one below explain how to quickly make your application do set display options for PDF in VBScript and VB6 with the help of ByteScout PDF SDK. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. Detailed tutorials and documentation are available along with installed ByteScout PDF SDK if you'd like to dive deeper into the topic and the details of the API.

You can download free trial version of ByteScout PDF SDK from our website to see and try many others source code samples for VBScript and VB6.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gdsQ0EAqwGQ](https://www.youtube.com/watch?v=gdsQ0EAqwGQ)




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