## How to set inter character spacing for text in PDF in VBScript and VB6 with ByteScout PDF SDK

### Tutorial on how to set inter character spacing for text in PDF in VBScript and VB6

These source code samples are listed and grouped by their programming language and functions they use. Want to set inter character spacing for text in PDF in your VBScript and VB6 app? ByteScout PDF SDK is designed for it. ByteScout PDF SDK is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

You will save a lot of time on writing and testing code as you may just take the VBScript and VB6 code from ByteScout PDF SDK for set inter character spacing for text in PDF below and use it in your application. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout PDF SDK in VBScript and VB6 is also explained in the documentation included along with the product.

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

##### ****IntercharacterSpacing.vbs:**
    
```
' This example demonstrates how to change the intercharacter spacing.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

Set font = comHelpers.CreateSystemFont("Arial", 16)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
Set stringFormat = comHelpers.CreateStringFormat()

' Standard spacing
stringFormat.CharacterSpacing = 0.0
canvas.DrawString_4 "Standard intercharacter spacing 0.0", (font), (brush), 20, 20, (stringFormat)

' Increased spacing 
stringFormat.CharacterSpacing = 1.0
canvas.DrawString_4 "Increased intercharacter spacing 1.0", (font), (brush), 20, 50, (stringFormat)

' Reduced spacing
stringFormat.CharacterSpacing = -0.75
canvas.DrawString_4 "Reduced intercharacter spacing -0.75", (font), (brush), 20, 80, (stringFormat)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->