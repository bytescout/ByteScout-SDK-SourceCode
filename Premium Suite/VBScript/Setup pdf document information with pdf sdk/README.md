## setup pdf document information with pdf sdk in VBScript using ByteScout Premium Suite

### Learn to code setup pdf document information with pdf sdk in VBScript: How-To tutorial

The samples of source code documentation give a quick and simple method to apply a required functionality into your application. Setup pdf document information with pdf sdk in VBScript can be applied with ByteScout Premium Suite. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

This rich and prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and options you should do calling the API to implement setup pdf document information with pdf sdk. If you want to know how it works, then this VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it. Use of ByteScout Premium Suite in VBScript is also described in the documentation included along with the product.

Trial version along with the source code samples for VBScript can be downloaded from our website

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