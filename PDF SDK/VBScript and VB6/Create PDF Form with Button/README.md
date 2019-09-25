## How to create PDF form with button in VBScript and VB6 with ByteScout PDF SDK

### How to create PDF form with button in VBScript and VB6

The sample source code below will teach you how to create PDF form with button in VBScript and VB6. ByteScout PDF SDK is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms and you can use it to create PDF form with button with VBScript and VB6.

This code snippet below for ByteScout PDF SDK works best when you need to quickly create PDF form with button in your VBScript and VB6 application. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Code testing will allow the function to be tested and work properly with your data.

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

##### ****Buttons.vbs:**
    
```
' This example demonstrates how to create a button and decorate it.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Create a button
Set button1 = comHelpers.CreatePushButton(50, 50, 100, 30, "button1")
button1.Caption = "Button"
' Decorate the button with various styles
button1.BackgroundColor = comHelpers.CreateColorRGB(192, 192, 255)
button1.BorderWidth = 2
button1.BorderStyle = comHelpers.BORDERSTYLE_BEVELED
button1.BorderColor = comHelpers.CreateColorRGB(0, 0, 128)
button1.Font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 16)
button1.FontColor = comHelpers.CreateColorRGB(0, 0, 0)
button1.HighlightingMode = comHelpers.PUSHBUTTONHIGHLIGHTINGMODE_OUTLINE

' Add button to the page
page1.Annotations.Add(button1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->