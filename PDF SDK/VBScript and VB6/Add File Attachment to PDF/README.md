## How to add file attachment to PDF in VBScript and VB6 using ByteScout PDF SDK

### The tutorial below will demonstrate how to add file attachment to PDF in VBScript and VB6

Sample source code below will show you how to cope with a difficult task like add file attachment to PDF in VBScript and VB6. ByteScout PDF SDK: the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings. It can add file attachment to PDF in VBScript and VB6.

Fast application programming interfaces of ByteScout PDF SDK for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to add file attachment to PDF. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Detailed tutorials and documentation are available along with installed ByteScout PDF SDK if you'd like to dive deeper into the topic and the details of the API.

Our website provides trial version of ByteScout PDF SDK for free. It also includes documentation and source code samples.

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

##### ****FileAttachmentAnnotation.vbs:**
    
```
' This example demonstrates how to attach a file to PDF document.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Attach file
Set fileAttachment = comHelpers.CreateFileAttachmentAnnotation("sample_attachment.txt", 20, 20, 20, 20)
fileAttachment.Icon = comHelpers.FILEATTACHMENTANNOTATIONICON_PAPERCLIP
page1.Annotations.Add(fileAttachment)

' Instruct PDF viewer application to show attachments pane on startup
pdfDocument.PageMode = comHelpers.PAGEMODE_ATTACHMENT

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->    

<!-- code block begin -->

##### ****sample_attachment.txt:**
    
```
sample_attachment.txt

1234567890
abcdefghijklmnopqrstuvwxyz
```

<!-- code block end -->