## How to create bookmarks for navigation in PDF in VBScript and VB6 and ByteScout PDF SDK

### How to code in VBScript and VB6 to create bookmarks for navigation in PDF with this step-by-step tutorial

Every ByteScout tool contains example VBScript and VB6 source codes that you can find here or in the folder with installed ByteScout product. What is ByteScout PDF SDK? It is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms. It can help you to create bookmarks for navigation in PDF in your VBScript and VB6 application.

You will save a lot of time on writing and testing code as you may just take the VBScript and VB6 code from ByteScout PDF SDK for create bookmarks for navigation in PDF below and use it in your application. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Enjoy writing a code with ready-to-use sample codes in VBScript and VB6.

Our website provides trial version of ByteScout PDF SDK for free. It also includes documentation and source code samples.

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