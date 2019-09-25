## How to create URI (link) action in PDF in VBScript and VB6 with ByteScout PDF SDK

### How to create URI (link) action in PDF in VBScript and VB6

Every ByteScout tool contains example VBScript and VB6 source codes that you can find here or in the folder with installed ByteScout product. Want to create URI (link) action in PDF in your VBScript and VB6 app? ByteScout PDF SDK is designed for it. ByteScout PDF SDK is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout PDF SDK. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! You can use these VBScript and VB6 sample examples in one or many applications.

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

##### ****UriAction.vbs:**
    
```
' This example demonstrates how to create URI (link) action.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add button
Set button1 = comHelpers.CreatePushButton(20, 20, 150, 25, "button1")
button1.Caption = "BYTESCOUT.COM"
' Add URI action
Set uriAction = comHelpers.CreateURIAction("http://bytescout.com/")
button1.OnActivated = uriAction
page1.Annotations.Add(button1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->