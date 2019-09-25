## How to add file attachment to pdf with pdf sdk in VBScript with ByteScout PDF Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to add file attachment to pdf with pdf sdk in VBScript

These sample source codes on this page below are displaying how to add file attachment to pdf with pdf sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can add file attachment to pdf with pdf sdk in VBScript.

The SDK samples given below describe how to quickly make your application do add file attachment to pdf with pdf sdk in VBScript with the help of ByteScout PDF Suite.  Simply copy and paste in your VBScript project or application you and then run your app! If you want to use these VBScript sample examples in one or many applications then they can be used easily.

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