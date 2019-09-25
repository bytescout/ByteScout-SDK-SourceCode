## How to add goto action to pdf with pdf sdk in VBScript with ByteScout PDF Suite

### This code in VBScript shows how to add goto action to pdf with pdf sdk with this how to tutorial

An easy to understand sample source code to learn how to add goto action to pdf with pdf sdk in VBScript ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can add goto action to pdf with pdf sdk in VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for add goto action to pdf with pdf sdk below and use it in your application. Just copy and paste the code into your VBScript application’s code and follow the instructions. Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

Trial version of ByteScout PDF Suite is available for free. Source code samples are included to help you with your VBScript app.

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

##### ****GoToAction.vbs:**
    
```
' This example demonstrates how to create a button with GoTo action.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)
Set page2 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page2)

Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 18)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Mark action target with text
page2.Canvas.DrawString "Action target", (timesFont), (blackBrush), 20, 200

' Create button
Set button1 = comHelpers.CreatePushButton(20, 20, 100, 25, "button1")
button1.Caption = "Go To Page 2"

' Create action to go to page 2 at 200 points from the top
button1.OnActivated = comHelpers.CreateGoToAction(comHelpers.CreateDestination((page2), 200))

page1.Annotations.Add(button1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->