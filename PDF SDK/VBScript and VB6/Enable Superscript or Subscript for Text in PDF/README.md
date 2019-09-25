## enable superscript or subscript for text in PDF in VBScript and VB6 using ByteScout PDF SDK

### enable superscript or subscript for text in PDF in VBScript and VB6

ByteScout tutorials explain the material for programmers who use VBScript and VB6. ByteScout PDF SDK was made to help with enable superscript or subscript for text in PDF in VBScript and VB6. ByteScout PDF SDK is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms.

Fast application programming interfaces of ByteScout PDF SDK for VBScript and VB6 plus the instruction and the VBScript and VB6 code below will help you quickly learn enable superscript or subscript for text in PDF. This VBScript and VB6 sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. This basic programming language sample code for VBScript and VB6 will do the whole work for you in implementing enable superscript or subscript for text in PDF in your app.

Trial version can be obtained from our website for free. It includes this and other source code samples for VBScript and VB6.

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

##### ****SuperscripAndSubscript.vbs:**
    
```
' This example demonstrates how to create a document and save it to file.

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
Set stringFormat = comHelpers.CreateStringFormat()
xPosition = 20

' Draw normal string
page1.Canvas.DrawString_4 "Normal text ", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Normal text ")

' Draw subscript string 
stringFormat.Rise = -5
page1.Canvas.DrawString_4 "Subscript", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Subscript")

' draw superscript string
stringFormat.Rise = +5
page1.Canvas.DrawString_4 "Superscript", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Superscript")

' Draw the baseline
Set pen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 255), 1.0)
pen.Opacity = 50
page1.Canvas.DrawLine (pen), 20, 50 + font.Size, xPosition, 50 + font.Size

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->