## zugferd invoice extraction with pdf extractor sdk in VBScript with ByteScout PDF Suite

### Learn to code in VBScript to make zugferd invoice extraction with pdf extractor sdk with this simple How-To tutorial

This page helps you to learn from code samples for programming in VBScript. Zugferd invoice extraction with pdf extractor sdk in VBScript can be applied with ByteScout PDF Suite. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

 Want to speed up the application development? Then this VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout PDF Suite. If you want to know how it works, then this VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it. Updated and detailed documentation and tutorials are available along with installed ByteScout PDF Suite if you'd like to learn more about the topic and the details of the API.

 If you want to try other samples for VBScript then free trial version of ByteScout PDF Suite is available on our website.

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