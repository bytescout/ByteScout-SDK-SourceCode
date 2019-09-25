## How to copy pages from one pdf document to another with pdf sdk in VBScript with ByteScout Premium Suite

### How to write a robust code in VBScript to copy pages from one pdf document to another with pdf sdk with this step-by-step tutorial

The documentation is designed for a specific purpose to help you to apply the features on your side. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to copy pages from one pdf document to another with pdf sdk with VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly copy pages from one pdf document to another with pdf sdk in your VBScript application. Just copy and paste the code into your VBScript application’s code and follow the instructions. This basic programming language sample code for VBScript will do the whole work for you to copy pages from one pdf document to another with pdf sdk.

You can download free trial version of ByteScout Premium Suite from our website to see and try many others source code samples for VBScript.

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

##### ****CopyPagesFromOneDocumentToAnother.vbs:**
    
```
' This example demonstrates how to copy pages from one document to another

' Open first document
Set pdfDocument1 = CreateObject("Bytescout.PDF.Document")
pdfDocument1.RegistrationName = "demo"
pdfDocument1.RegistrationKey = "demo"
pdfDocument1.Load("document1.pdf")
' Open second document
Set pdfDocument2 = CreateObject("Bytescout.PDF.Document")
pdfDocument2.RegistrationName = "demo"
pdfDocument2.RegistrationKey = "demo"
pdfDocument2.Load("document2.pdf")

' Add pages from document2 to document1
For i = 0 To pdfDocument2.Pages.Count - 1
    pdfDocument1.Pages.Add(pdfDocument2.Pages.Item(i))
Next

' Save document to file
pdfDocument1.Save("merged.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "merged.pdf", 1, false

```

<!-- code block end -->