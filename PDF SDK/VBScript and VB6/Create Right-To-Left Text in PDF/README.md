## How to create right to left text in PDF in VBScript and VB6 using ByteScout PDF SDK

### This tutorial will show how to create right to left text in PDF in VBScript and VB6

These source code samples are listed and grouped by their programming language and functions they use. ByteScout PDF SDK is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings. It can be used to create right to left text in PDF using VBScript and VB6.

The SDK samples like this one below explain how to quickly make your application do create right to left text in PDF in VBScript and VB6 with the help of ByteScout PDF SDK. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Use of ByteScout PDF SDK in VBScript and VB6 is also explained in the documentation included along with the product.

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

##### ****RightToLeftText.vbs:**
    
```
' This example demonstrates how to draw right-to-left text.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set font = comHelpers.CreateSystemFont("Arial", 16)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Set right to left text direction
Set stringFormat = comHelpers.CreateStringFormat()
stringFormat.DirectionRightToLeft = True

page1.Canvas.DrawString_4 "???? ????? ?????", (font), (brush), page1.Width - 20, 30, (stringFormat)
page1.Canvas.DrawString_4 "???, ?????, ????", (font), (brush), page1.Width - 20, 50, (stringFormat)
page1.Canvas.DrawString_4 "?? ?? ??", (font), (brush), page1.Width - 20, 70, (stringFormat)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->