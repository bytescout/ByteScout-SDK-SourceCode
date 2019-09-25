## setup PDF document information in VBScript and VB6 with ByteScout PDF SDK

### Make setup PDF document information in VBScript and VB6: ### Tutorial on how to do setup PDF document information in VBScript and VB6

Here you may find thousands pre-made source code pieces for easy implementation in your own programming VBScript and VB6 projects. Setup PDF document information in VBScript and VB6 can be implemented with ByteScout PDF SDK. ByteScout PDF SDK is the SDK for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

Fast application programming interfaces of ByteScout PDF SDK for VBScript and VB6 plus the instruction and the VBScript and VB6 code below will help you quickly learn setup PDF document information. This VBScript and VB6 sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. Further enhancement of the code will make it more vigorous.

ByteScout PDF SDK free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

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

##### ****DocumentInformation.vbs:**
    
```
' This example demonstrates how to set various document properties.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Change document information.
' Open Document Properties in PDF viewer to see the changes.
pdfDocument.DocumentInfo.Author = "John Doe"
pdfDocument.DocumentInfo.Creator = "My Application"
pdfDocument.DocumentInfo.Keywords = "accounting,invoice"
pdfDocument.DocumentInfo.Title = "Invoice #12345"
pdfDocument.DocumentInfo.Subject = "Invoice"
pdfDocument.DocumentInfo.CreationDate = CDate("2015-12-21")
pdfDocument.DocumentInfo.ModificationDate = Now

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->