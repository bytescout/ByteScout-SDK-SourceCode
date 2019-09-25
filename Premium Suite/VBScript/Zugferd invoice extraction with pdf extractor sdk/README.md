## zugferd invoice extraction with pdf extractor sdk in VBScript with ByteScout Premium Suite

### How to apply ByteScout Premium Suite for zugferd invoice extraction with pdf extractor sdk in VBScript

Easy to understand coding instructions are written to assist you to try-out the features without the requirement to write your own code. ByteScout Premium Suite was created to assist zugferd invoice extraction with pdf extractor sdk in VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

The below SDK samples describe how to quickly make your application do zugferd invoice extraction with pdf extractor sdk in VBScript with the help of ByteScout Premium Suite. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. Enjoy writing a code with ready-to-use sample VBScript codes to add zugferd invoice extraction with pdf extractor sdk functions using ByteScout Premium Suite in VBScript.

Trial version can be downloaded from our website for free. It contains this and other source code samples for VBScript.

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