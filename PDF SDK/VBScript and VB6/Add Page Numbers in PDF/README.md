## How to add page numbers in PDF in VBScript and VB6 and ByteScout PDF SDK

### Write code in VBScript and VB6 to add page numbers in PDF with this step-by-step tutorial

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout PDF SDK is the pdf library that can create, update and modify PDF files. Supports text with fonts and style selections, layers, form fields, drawing lines and objects, automatic tables, images. Can be used to create and fill pdf forms and you can use it to add page numbers in PDF with VBScript and VB6.

The SDK samples like this one below explain how to quickly make your application do add page numbers in PDF in VBScript and VB6 with the help of ByteScout PDF SDK. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! You can use these VBScript and VB6 sample examples in one or many applications.

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

##### ****PageNumbers.vbs:**
    
```
' This example demonstrates how to add page numbers (labels) visible in the page thumbnails panel of PDF viewer.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add twenty pages
For i = 0 To 19
    pdfDocument.Pages.Add(comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4))
Next

' First five pages will have roman numbers I, II, III, ...
Set pageLabel = comHelpers.CreatePageLabel(0, comHelpers.PAGENUMBERINGSTYLE_UPPERCASEROMAN)
pdfDocument.PageLabels.Add(pageLabel)

' Next five pages will have arabic numbers 6, 7, 8, ...
pageLabel.Style = comHelpers.PAGENUMBERINGSTYLE_DECIMALARABIC
pageLabel.StartPortion = 6
pageLabel.FirstPageIndex = 5
pdfDocument.PageLabels.Add(pageLabel)

' Next five pages will have complex page numbers with prefix A-11, A-12, A-13, ...
pageLabel.Style = comHelpers.PAGENUMBERINGSTYLE_DECIMALARABIC
pageLabel.Prefix = "A-"
pageLabel.StartPortion = 11
pageLabel.FirstPageIndex = 10
pdfDocument.PageLabels.Add(pageLabel)

' Next five pages will use letters as page numbers P, Q, R, ...
pageLabel.Prefix = ""
pageLabel.Style = comHelpers.PAGENUMBERINGSTYLE_UPPERCASELETTERS
pageLabel.StartPortion = 16
pageLabel.FirstPageIndex = 15
pdfDocument.PageLabels.Add(pageLabel)

' Force PDF viewer to show page thumbnails panel on start up
pdfDocument.PageMode = comHelpers.PAGEMODE_THUMBNAIL

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->