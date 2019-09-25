## How to create pdf form with button with pdf sdk in VBScript and ByteScout PDF Suite

### How to write a robust code in VBScript to create pdf form with button with pdf sdk with this step-by-step tutorial

Source code documentation samples give simple and easy method to install a needed feature into your application. What is ByteScout PDF Suite? It is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to create pdf form with button with pdf sdk in your VBScript application.

Want to quickly learn? This fast application programming interfaces of ByteScout PDF Suite for VBScript plus the guidelines and the code below will help you quickly learn how to create pdf form with button with pdf sdk. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Further improvement of the code will make it more robust.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### ****Buttons.vbs:**
    
```
' This example demonstrates how to create a button and decorate it.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Create a button
Set button1 = comHelpers.CreatePushButton(50, 50, 100, 30, "button1")
button1.Caption = "Button"
' Decorate the button with various styles
button1.BackgroundColor = comHelpers.CreateColorRGB(192, 192, 255)
button1.BorderWidth = 2
button1.BorderStyle = comHelpers.BORDERSTYLE_BEVELED
button1.BorderColor = comHelpers.CreateColorRGB(0, 0, 128)
button1.Font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 16)
button1.FontColor = comHelpers.CreateColorRGB(0, 0, 0)
button1.HighlightingMode = comHelpers.PUSHBUTTONHIGHLIGHTINGMODE_OUTLINE

' Add button to the page
page1.Annotations.Add(button1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->