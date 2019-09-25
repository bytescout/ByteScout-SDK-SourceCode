## How to add page numbers in pdf with pdf sdk in VBScript with ByteScout Premium Suite

### If you want to learn more then this tutorial will show how to add page numbers in pdf with pdf sdk in VBScript

On this page you will learn from code samples for programming in VBScript.Writing of the code to add page numbers in pdf with pdf sdk in VBScript can be executed by programmers of any level using ByteScout Premium Suite. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to add page numbers in pdf with pdf sdk using VBScript.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to add page numbers in pdf with pdf sdk.  Simply copy and paste in your VBScript project or application you and then run your app! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

If you want to try other source code samples then the free trial version of ByteScout Premium Suite is available for download from our website. Just try other source code samples for VBScript.

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