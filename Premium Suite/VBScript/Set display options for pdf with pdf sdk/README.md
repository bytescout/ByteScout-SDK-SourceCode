## How to set display options for pdf with pdf sdk in VBScript with ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to set display options for pdf with pdf sdk in VBScript

The code displayed below will guide you to install an VBScript app to set display options for pdf with pdf sdk. Want to set display options for pdf with pdf sdk in your VBScript app? ByteScout Premium Suite is designed for it. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

The following code snippet for ByteScout Premium Suite works best when you need to quickly set display options for pdf with pdf sdk in your VBScript application.  Simply copy and paste in your VBScript project or application you and then run your app! Enjoy writing a code with ready-to-use sample VBScript codes.

You can download free trial version of ByteScout Premium Suite from our website with this and other source code samples for VBScript.

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