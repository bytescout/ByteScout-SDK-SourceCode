## How to draw string in pdf with pdf sdk in VBScript with ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to draw string in pdf with pdf sdk in VBScript

An easy to understand sample source code to learn how to draw string in pdf with pdf sdk in VBScript What is ByteScout Premium Suite? It is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to draw string in pdf with pdf sdk in your VBScript application.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to draw string in pdf with pdf sdk. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample codes in VBScript.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****DrawString.vbs:**
    
```
' This example demonstrates how to draw a text.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Draw simple text
Set font = comHelpers.CreateSystemFont("Arial", 24)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
page1.Canvas.DrawString "Simple text.", (font), (blackBrush), 20, 20

' Draw text with alignment in specified rectangle
Set stringFormat = comHelpers.CreateStringFormat()
stringFormat.HorizontalAlign = comHelpers.HORIZONTALALIGN_RIGHT
stringFormat.VerticalAlign = comHelpers.VERTICALALIGN_BOTTOM
page1.Canvas.DrawString_7 "Aligned text", (font), (blackBrush), 20, 100, 200, 60, (stringFormat)
page1.Canvas.DrawRectangle comHelpers.CreateSolidPen(comHelpers.CreateColorGray(0), 1.0), 20, 100, 200, 60

' Draw colored text
Set boldFont = comHelpers.CreateSystemFont2("Arial", 32, True, False, False, False)
Set redBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
Set bluePen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 255), 1.0)
page1.Canvas.DrawString "Colored text", (boldFont), (redBrush), 20, 200
page1.Canvas.DrawString_3 "Outlined colored text", (boldFont), (redBrush), (bluePen), 20, 240
page1.Canvas.DrawString_2 "Outlined transparent text", (boldFont), (bluePen), 20, 280

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->