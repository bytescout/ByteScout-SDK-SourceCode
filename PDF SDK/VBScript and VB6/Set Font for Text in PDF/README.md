## How to set font for text in PDF in VBScript and VB6 using ByteScout PDF SDK

### Write code in VBScript and VB6 to set font for text in PDF with this step-by-step tutorial

The sample source codes on this page shows how to set font for text in PDF in VBScript and VB6. ByteScout PDF SDK is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings and you can use it to set font for text in PDF with VBScript and VB6.

This rich sample source code in VBScript and VB6 for ByteScout PDF SDK includes the number of functions and options you should do calling the API to set font for text in PDF. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. You can use these VBScript and VB6 sample examples in one or many applications.

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

##### ****Fonts.vbs:**
    
```
' This example demonstrates how to use fonts.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Use standard PDF font
Set standardFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 16)
canvas.DrawString "Standard font.", (standardFont), (brush), 20, 20

' Use font installed in system
Set systemFont = comHelpers.CreateSystemFont("Arial", 16)
canvas.DrawString "Windows font.", (systemFont), (brush), 20, 50

' Use font loaded from file
Set fontFromFile = comHelpers.LoadFontFromFile("VeraBI.ttf", 16)
canvas.DrawString "Font loaded from file.", (fontFromFile), (brush), 20, 80

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->