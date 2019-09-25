## How to add link to page in PDF in VBScript and VB6 using ByteScout PDF SDK

### Write code in VBScript and VB6 to add link to page in PDF with this step-by-step tutorial

These source code samples are listed and grouped by their programming language and functions they use. ByteScout PDF SDK is the SDK for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings and you can use it to add link to page in PDF with VBScript and VB6.

This rich sample source code in VBScript and VB6 for ByteScout PDF SDK includes the number of functions and options you should do calling the API to add link to page in PDF. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Detailed tutorials and documentation are available along with installed ByteScout PDF SDK if you'd like to dive deeper into the topic and the details of the API.

Download free trial version of ByteScout PDF SDK from our website with this and other source code samples for VBScript and VB6.

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

##### ****LinkToPage.vbs:**
    
```
' This example demonstrates how to create a navigation link to a page.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add two pages
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)
Set page2 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page2)

Set font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 12)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Create link annotation pointing to Page 2, 200 Points from the top.
Set destination = comHelpers.CreateDestination((page2), 200)
Set link = comHelpers.CreateLinkAnnotation((destination), 20, 20, 100, 25)
link.Color = comHelpers.CreateColorRGB(255, 0, 0) ' you can change the link color
page1.Annotations.Add(link)

' Draw link text (optional)
Set stringFormat = comHelpers.CreateStringFormat()
stringFormat.HorizontalAlign = comHelpers.HORIZONTALALIGN_CENTER
stringFormat.VerticalAlign = comHelpers.VERTICALALIGN_CENTER
page1.Canvas.DrawString_7 "Link to Page 2", (font), (brush), 20, 20, 100, 25, (stringFormat)

' Draw a text at the link target
page2.Canvas.DrawString "Link target", (font), (brush), 20, 200

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->