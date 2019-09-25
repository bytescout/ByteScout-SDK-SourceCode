## zugferd invoice extraction with pdf extractor sdk in VBScript using ByteScout Data Extraction Suite

### zugferd invoice extraction with pdf extractor sdk in VBScript

We regularly create and update our sample code library so you may quickly learn zugferd invoice extraction with pdf extractor sdk and the step-by-step process in VBScript. Zugferd invoice extraction with pdf extractor sdk in VBScript can be applied with ByteScout Data Extraction Suite. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

VBScript code snippet like this for ByteScout Data Extraction Suite works best when you need to quickly implement zugferd invoice extraction with pdf extractor sdk in your VBScript application. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Want to see how it works with your data then code testing will allow the function to be tested and work properly.

ByteScout Data Extraction Suite is available as a free trial. You may get it from our website along with all other source code samples for VBScript applications.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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

##### ****ExtractEmbeddedFilesFromPDF.vbs:**
    
```
' Create Bytescout.PDFExtractor.AttachmentExtractor object
Set AttachmentExtractor = CreateObject("Bytescout.PDFExtractor.AttachmentExtractor")
AttachmentExtractor.RegistrationName = "demo"
AttachmentExtractor.RegistrationKey = "demo"

' Load sample PDF document with embedded attachments
AttachmentExtractor.LoadDocumentFromFile("..\..\ZUGFeRD-invoice.pdf")

' Walk through attachments and save them
For i = 0 To AttachmentExtractor.Count - 1
    ' Save file to current folder with original name
    AttachmentExtractor.Save i, AttachmentExtractor.GetFileName(i) 
Next

WScript.Echo "Done! Click OK to open the XML invoice"

Set extractor = Nothing


```

<!-- code block end -->