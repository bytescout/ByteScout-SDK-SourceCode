## How to set show and hide widget in pdf with pdf sdk in VBScript using ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to set show and hide widget in pdf with pdf sdk in VBScript

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout Premium Suite: the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can set show and hide widget in pdf with pdf sdk in VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly set show and hide widget in pdf with pdf sdk in your VBScript application. Follow the instructions from scratch to work and copy the VBScript code. Enjoy writing a code with ready-to-use sample codes in VBScript.

You can download free trial version of ByteScout Premium Suite from our website with this and other source code samples for VBScript.

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