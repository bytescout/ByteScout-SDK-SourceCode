## How to add link to page in pdf with pdf sdk in VBScript with ByteScout Premium Suite

### How to write a robust code in VBScript to add link to page in pdf with pdf sdk with this step-by-step tutorial

The sample source code below will teach you how to add link to page in pdf with pdf sdk in VBScript. What is ByteScout Premium Suite? It is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to add link to page in pdf with pdf sdk in your VBScript application.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Premium Suite.  Simply copy and paste in your VBScript project or application you and then run your app! Further improvement of the code will make it more robust.

If you want to try other source code samples then the free trial version of ByteScout Premium Suite is available for download from our website. Just try other source code samples for VBScript.

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