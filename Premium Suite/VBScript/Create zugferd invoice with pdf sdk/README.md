## How to create zugferd invoice with pdf sdk in VBScript with ByteScout Premium Suite

### Learn to code in VBScript to create zugferd invoice with pdf sdk with this step-by-step tutorial

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can create zugferd invoice with pdf sdk in VBScript.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to create zugferd invoice with pdf sdk.  Simply copy and paste in your VBScript project or application you and then run your app! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

Our website gives trial version of ByteScout Premium Suite for free. It also includes documentation and source code samples.

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

##### ****FileAttachmentAnnotations.vbs:**
    
```
' This example demonstrates how to attach a file to PDF document.

' Open pdf document
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' Load existing document
pdfDocument.Load("Invoice.pdf")

Set comHelpers = pdfDocument.ComHelpers

' Attach ZUGFeRD XML file
Set fileAttachment = comHelpers.CreateFileAttachmentAnnotation("ZUGFeRD-invoice.xml", 0, 0, 0, 0)
pdfDocument.Pages.Item(0).Annotations.Add(fileAttachment)

' Instruct PDF viewer applications to show attachments pane on startup (optional)
pdfDocument.PageMode = comHelpers.PAGEMODE_ATTACHMENT

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
```

<!-- code block end -->