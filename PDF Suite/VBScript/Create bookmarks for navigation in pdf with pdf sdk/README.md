## How to create bookmarks for navigation in pdf with pdf sdk in VBScript and ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to create bookmarks for navigation in pdf with pdf sdk in VBScript

These sample source codes on this page below are displaying how to create bookmarks for navigation in pdf with pdf sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript and you can use it to create bookmarks for navigation in pdf with pdf sdk with VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout PDF Suite.  Simply copy and paste in your VBScript project or application you and then run your app! Complete and detailed tutorials and documentation are available along with installed ByteScout PDF Suite if you'd like to learn more about the topic and the details of the API.

The trial version of ByteScout PDF Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****Bookmarks.vbs:**
    
```
' This example demonstrates how to create document outlines (bookmarks).

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

Set font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 18)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Create pages
For i = 0 To 2
    Set newPage = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
    newPage.Canvas.DrawString "Page " & (i + 1), (font), (brush), 20, 20
    pdfDocument.Pages.Add(newPage)
Next

' Create outlines:

Set destination1 = comHelpers.CreateDestination(pdfDocument.Pages.Item(0), 0)
Set outline1 = comHelpers.CreateOutline_2("Page 1", (destination1))
pdfDocument.Outlines.Add(outline1)

' Example of sub-bookmark
Set destination2 = comHelpers.CreateDestination(pdfDocument.Pages.Item(1), 0)
Set outline2 = comHelpers.CreateOutline_2("Page 2", (destination2))
pdfDocument.Outlines.Item(0).Kids.Add(outline2)

Set destination3 = comHelpers.CreateDestination(pdfDocument.Pages.Item(2), 0)
Set outline3 = comHelpers.CreateOutline_2("Page 3", (destination3))
pdfDocument.Outlines.Add(outline3)

' Force PDF viewer to show Bookmarks panel at start up.
pdfDocument.PageMode = comHelpers.PAGEMODE_OUTLINES

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->