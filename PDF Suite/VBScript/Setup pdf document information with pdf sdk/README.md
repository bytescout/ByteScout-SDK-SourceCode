## setup pdf document information with pdf sdk in VBScript with ByteScout PDF Suite

### How to apply ByteScout PDF Suite for setup pdf document information with pdf sdk in VBScript

Writing of the code to setup pdf document information with pdf sdk in VBScript can be done by developers of any level using ByteScout PDF Suite. ByteScout PDF Suite helps with setup pdf document information with pdf sdk in VBScript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

 Want to speed up the application development? Then this VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout PDF Suite.  Just copy and paste this VBScript sample code to your VBScript application's code editor, add a reference to ByteScout PDF Suite (if you haven't added yet) and you are ready to go! Updated and detailed documentation and tutorials are available along with installed ByteScout PDF Suite if you'd like to learn more about the topic and the details of the API.

Our website gives free trial version of ByteScout PDF Suite. It includes all these source code samples with the purpose to assist you with your VBScript application implementation.

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