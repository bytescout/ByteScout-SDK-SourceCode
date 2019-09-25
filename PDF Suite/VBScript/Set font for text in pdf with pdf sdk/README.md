## How to set font for text in pdf with pdf sdk in VBScript with ByteScout PDF Suite

### How to write a robust code in VBScript to set font for text in pdf with pdf sdk with this step-by-step tutorial

On this page you will learn from code samples for programming in VBScript.Writing of the code to set font for text in pdf with pdf sdk in VBScript can be executed by programmers of any level using ByteScout PDF Suite. What is ByteScout PDF Suite? It is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to set font for text in pdf with pdf sdk in your VBScript application.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for set font for text in pdf with pdf sdk below and use it in your application. Just copy and paste the code into your VBScript application’s code and follow the instructions. Want to see how it works with your data then code testing will allow the function to be tested and work properly.

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