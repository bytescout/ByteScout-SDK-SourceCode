## How to set inter character spacing for text in pdf with pdf sdk in VBScript with ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to set inter character spacing for text in pdf with pdf sdk in VBScript

An easy to understand sample source code to learn how to set inter character spacing for text in pdf with pdf sdk in VBScript What is ByteScout PDF Suite? It is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to set inter character spacing for text in pdf with pdf sdk in your VBScript application.

The SDK samples given below describe how to quickly make your application do set inter character spacing for text in pdf with pdf sdk in VBScript with the help of ByteScout PDF Suite. Just copy and paste the code into your VBScript application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample VBScript codes.

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

##### ****IntercharacterSpacing.vbs:**
    
```
' This example demonstrates how to change the intercharacter spacing.

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

' Standard spacing
stringFormat.CharacterSpacing = 0.0
canvas.DrawString_4 "Standard intercharacter spacing 0.0", (font), (brush), 20, 20, (stringFormat)

' Increased spacing 
stringFormat.CharacterSpacing = 1.0
canvas.DrawString_4 "Increased intercharacter spacing 1.0", (font), (brush), 20, 50, (stringFormat)

' Reduced spacing
stringFormat.CharacterSpacing = -0.75
canvas.DrawString_4 "Reduced intercharacter spacing -0.75", (font), (brush), 20, 80, (stringFormat)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->