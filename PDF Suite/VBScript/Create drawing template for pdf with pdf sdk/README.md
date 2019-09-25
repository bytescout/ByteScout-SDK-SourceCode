## How to create drawing template for pdf with pdf sdk in VBScript using ByteScout PDF Suite

### This code in VBScript shows how to create drawing template for pdf with pdf sdk with this how to tutorial

Source code documentation samples give simple and easy method to install a needed feature into your application. What is ByteScout PDF Suite? It is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to create drawing template for pdf with pdf sdk in your VBScript application.

The SDK samples given below describe how to quickly make your application do create drawing template for pdf with pdf sdk in VBScript with the help of ByteScout PDF Suite. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! If you want to use these VBScript sample examples in one or many applications then they can be used easily.

Our website gives trial version of ByteScout PDF Suite for free. It also includes documentation and source code samples.

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

##### ****Templates.vbs:**
    
```
' This example demonstrates how to use templates.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Prepare simple template (for example, a logo) and draw it on every page:

' Create template of specified size
Set template = comHelpers.CreateGraphicsTemplate(250, 50)
' Draw the logo
Set lightBlueBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(200, 200, 255))
template.DrawRectangle_2 (lightBlueBrush), 0, 0, 250, 50
Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMESBOLDITALIC, 24)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
template.DrawString "My Company Logo", (timesFont), (blackBrush), 30, 10

' Add few pages and draw the prepared template on each one
For i = 0 To 2
    Set page = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
    page.Canvas.DrawTemplate (template), 10, 10
    pdfDocument.Pages.Add(page)
Next

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->