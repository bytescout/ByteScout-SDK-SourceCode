## How to load existing pdf document with pdf sdk in VBScript and ByteScout Premium Suite

### Learn to load existing pdf document with pdf sdk in VBScript

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout Premium Suite: the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can load existing pdf document with pdf sdk in VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly load existing pdf document with pdf sdk in your VBScript application.  Simply copy and paste in your VBScript project or application you and then run your app! Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### ****LoadDocument.vbs:**
    
```
' This example demonstrates how to load and modify an existing document.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

'  Load existing document
pdfDocument.Load("sample.pdf")
        
' Add new page to loaded document
Set newPage = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 24)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
newPage.Canvas.DrawString "New Page", (timesFont), (blackBrush), 20, 20
pdfDocument.Pages.Add(newPage)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->