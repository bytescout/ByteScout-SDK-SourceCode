## How to set graphics state for pdf with pdf sdk in VBScript with ByteScout PDF Suite

### Learn to code in VBScript to set graphics state for pdf with pdf sdk with this step-by-step tutorial

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can set graphics state for pdf with pdf sdk in VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout PDF Suite for VBScript plus the guidelines and the code below will help you quickly learn how to set graphics state for pdf with pdf sdk. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout PDF Suite in VBScript is also described in the documentation included along with the product.

If you want to try other source code samples then the free trial version of ByteScout PDF Suite is available for download from our website. Just try other source code samples for VBScript.

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

##### ****GraphicsState.vbs:**
    
```
' This example demonstrates how to save and restore the graphics state.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set canvas = page1.Canvas

' Keep current graphics state
canvas.SaveGraphicsState()

' Transform coordinates and draw rectangle
canvas.TranslateTransform 200, 200
canvas.RotateTransform 45
Set blueBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(0, 0, 255))
canvas.DrawRectangle_2 (blueBrush), 0, 0, 100, 100

' Restore the state and draw the same rectangle
canvas.RestoreGraphicsState()
Set redBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorRGB(255, 0, 0))
canvas.DrawRectangle_2 (redBrush), 200, 200, 100, 100

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->