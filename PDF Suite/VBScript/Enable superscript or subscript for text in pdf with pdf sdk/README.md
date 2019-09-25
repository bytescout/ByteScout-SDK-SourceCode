## enable superscript or subscript for text in pdf with pdf sdk in VBScript using ByteScout PDF Suite

### How to apply ByteScout PDF Suite for enable superscript or subscript for text in pdf with pdf sdk in VBScript

Easy to understand coding instructions are written to assist you to try-out the features without the requirement to write your own code. ByteScout PDF Suite was made to help with enable superscript or subscript for text in pdf with pdf sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Save time on writing and testing code by using the code below and use it in your application. If you want to know how it works, then this VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it. Check these VBScript sample code examples to see if they acknowledge to your needs and requirements for the project.

ByteScout PDF Suite is available as a free trial. You may get it from our website along with all other source code samples for VBScript applications.

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