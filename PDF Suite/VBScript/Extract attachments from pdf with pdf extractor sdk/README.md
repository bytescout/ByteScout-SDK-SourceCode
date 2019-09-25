## How to extract attachments from pdf with pdf extractor sdk in VBScript using ByteScout PDF Suite

### This code in VBScript shows how to extract attachments from pdf with pdf extractor sdk with this how to tutorial

This sample source code below will display you how to extract attachments from pdf with pdf extractor sdk in VBScript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can extract attachments from pdf with pdf extractor sdk in VBScript.

The following code snippet for ByteScout PDF Suite works best when you need to quickly extract attachments from pdf with pdf extractor sdk in your VBScript application. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

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

##### ****ExtractAttachments.vbs:**
    
```
' Create Bytescout.PDFExtractor.extractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.AttachmentExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document with embedded attachments
extractor.LoadDocumentFromFile("..\..\attachments.pdf")

' Iterate through attachments and save them
For i = 0 To extractor.Count - 1
    ' Save file to current folder with original name
    extractor.Save i, extractor.GetFileName(i)
Next

MsgBox "Done: " & CStr(extractor.Count) & " attachments extracted"

Set extractor = Nothing


```

<!-- code block end -->