## How to set show and hide widget in pdf with pdf sdk in VBScript using ByteScout PDF Suite

### Step-by-step tutorial on how to set show and hide widget in pdf with pdf sdk in VBScript

The sample shows instructions and algorithm of how to set show and hide widget in pdf with pdf sdk and how to make it run in your VBScript application. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can set show and hide widget in pdf with pdf sdk in VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout PDF Suite. Just copy and paste the code into your VBScript application’s code and follow the instructions. This basic programming language sample code for VBScript will do the whole work for you to set show and hide widget in pdf with pdf sdk.

ByteScout PDF Suite free trial version is available on our website. VBScript and other programming languages are supported.

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

##### ****ShowHideWidget.vbs:**
    
```
' This example demonstrates how to show/hide a widget in document.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Create widget that will be shown/hidden
Set editBox1 = comHelpers.CreateEditBox(20, 20, 100, 25, "editBox1")
editBox1.Text = "editBox1"
page1.Annotations.Add(editBox1)

' Create button that will show the widget
Set buttonShow = comHelpers.CreatePushButton(20, 80, 50, 25, "buttonShow")
buttonShow.Caption = "Show"
page1.Annotations.Add(buttonShow)
' Add Show action
Set showAction = comHelpers.CreateHideAction(False)
showAction.Fields.Add(editBox1)
buttonShow.OnActivated = showAction

' Create button that will hide the widget
Set buttonHide = comHelpers.CreatePushButton(100, 80, 50, 25, "buttonHide")
buttonHide.Caption = "Hide"
page1.Annotations.Add(buttonHide)
' Add Hide action
Set hideAction = comHelpers.CreateHideAction(True)
hideAction.Fields.Add(editBox1)
buttonHide.OnActivated = hideAction

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->