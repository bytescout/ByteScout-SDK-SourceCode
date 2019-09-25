## How to draw string in pdf with pdf sdk in VBScript using ByteScout PDF Suite

### Learn to draw string in pdf with pdf sdk in VBScript

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. Want to draw string in pdf with pdf sdk in your VBScript app? ByteScout PDF Suite is designed for it. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for draw string in pdf with pdf sdk below and use it in your application.  Simply copy and paste in your VBScript project or application you and then run your app! Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

You can download free trial version of ByteScout PDF Suite from our website to see and try many others source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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