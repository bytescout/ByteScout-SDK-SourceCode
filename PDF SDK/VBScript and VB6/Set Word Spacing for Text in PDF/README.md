## How to set word spacing for text in PDF in VBScript and VB6 and ByteScout PDF SDK

### This tutorial will show how to set word spacing for text in PDF in VBScript and VB6

Source code documentation samples provide quick and easy way to add a required functionality into your application. ByteScout PDF SDK is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms and you can use it to set word spacing for text in PDF with VBScript and VB6.

This rich sample source code in VBScript and VB6 for ByteScout PDF SDK includes the number of functions and options you should do calling the API to set word spacing for text in PDF. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! Detailed tutorials and documentation are available along with installed ByteScout PDF SDK if you'd like to dive deeper into the topic and the details of the API.

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

##### ****WordSpacing.vbs:**
    
```
' This example demonstrates how to change the word spacing.

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

' Standard word spacing
stringFormat.WordSpacing = 0.0
canvas.DrawString_4 "Standard word spacing 0.0", (font), (brush), 20, 20, (stringFormat)

' Increased word spacing
stringFormat.WordSpacing = 5.0
canvas.DrawString_4 "Increased word spacing 5.0", (font), (brush), 20, 50, (stringFormat)

' Reduced word spacing
stringFormat.WordSpacing = -2.5
canvas.DrawString_4 "Reduced word spacing -2.5", (font), (brush), 20, 80, (stringFormat)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->