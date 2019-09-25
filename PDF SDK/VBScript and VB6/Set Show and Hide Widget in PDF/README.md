## How to set show and hide widget in PDF in VBScript and VB6 and ByteScout PDF SDK

### The tutorial below will demonstrate how to set show and hide widget in PDF in VBScript and VB6

The sample shows steps and algorithm of how to set show and hide widget in PDF and how to make it work in your VBScript and VB6 application. ByteScout PDF SDK: the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms. It can set show and hide widget in PDF in VBScript and VB6.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout PDF SDK. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout PDF SDK in VBScript and VB6 is also explained in the documentation included along with the product.

Free trial version of ByteScout PDF SDK is available on our website. Documentation and source code samples are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gdsQ0EAqwGQ](https://www.youtube.com/watch?v=gdsQ0EAqwGQ)




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