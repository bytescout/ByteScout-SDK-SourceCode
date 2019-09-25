## How to merge pdf documents with pdf extractor sdk in VBScript using ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to merge pdf documents with pdf extractor sdk in VBScript

The sample source codes on this page shows how to merge pdf documents with pdf extractor sdk in VBScript. What is ByteScout PDF Suite? It is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to merge pdf documents with pdf extractor sdk in your VBScript application.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for merge pdf documents with pdf extractor sdk below and use it in your application.  Simply copy and paste in your VBScript project or application you and then run your app! Further improvement of the code will make it more robust.

Our website gives trial version of ByteScout PDF Suite for free. It also includes documentation and source code samples.

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

##### ****MergeDocuments.vbs:**
    
```
' Create Bytescout.PDFExtractor.DocumentMerger object
Set merger = CreateObject("Bytescout.PDFExtractor.DocumentMerger")
merger.RegistrationName = "demo"
merger.RegistrationKey = "demo"

merger.Merge2 "..\..\sample1.pdf", "..\..\sample2.pdf", "result.pdf"
                
Set merger = Nothing

WScript.Echo "Merged document saved as 'result.pdf'."
```

<!-- code block end -->