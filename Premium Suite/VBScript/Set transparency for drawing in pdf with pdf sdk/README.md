## How to set transparency for drawing in pdf with pdf sdk in VBScript and ByteScout Premium Suite

### Learn to set transparency for drawing in pdf with pdf sdk in VBScript

These source code samples are assembled by their programming language and functions they apply. Want to set transparency for drawing in pdf with pdf sdk in your VBScript app? ByteScout Premium Suite is designed for it. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guidelines and the code below will help you quickly learn how to set transparency for drawing in pdf with pdf sdk. Follow the instructions from scratch to work and copy the VBScript code. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

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

##### ****Transparency.vbs:**
    
```
' This example demonstrates how to draw transparent objects.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Prepare pens and brushes
Set borderPen = comHelpers.CreateSolidPen(comHelpers.CreateColorGray(0), 2.0)

Set brush1 = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
Set brush2 = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255))

borderPen.Opacity = 50
brush1.Opacity = 30
brush2.Opacity = 60

' Draw normal rectangles
canvas.DrawRectangle_2 (brush1), 100, 100, 100, 100
canvas.DrawRectangle_3 (borderPen), (brush2), 150, 150, 100, 100

borderPen.Opacity = 80
brush1.Opacity = 60
brush2.Opacity = 30

' Draw rounded rectangles
canvas.DrawRoundedRectangle_2 (brush1), 220, 100, 100, 100, 10
canvas.DrawRoundedRectangle_3 (borderPen), (brush2), 270, 150, 100, 100, 10

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->