## compare pdf documents with pdf extractor sdk in VBScript using ByteScout Premium Suite

### Build compare pdf documents with pdf extractor sdk in VBScript: ### Step-by-step instructions on how to do compare pdf documents with pdf extractor sdk in VBScript

These source code samples are assembled by their programming language and functions they use. ByteScout Premium Suite helps with compare pdf documents with pdf extractor sdk in VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

If you want to quickly learn then these fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guideline and the VBScript code below will help you quickly learn compare pdf documents with pdf extractor sdk. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. VBScript application implementation mostly involves various stages of the software development so even if the functionality works please check it with your data and the production environment.

Our website gives free trial version of ByteScout Premium Suite. It includes all these source code samples with the purpose to assist you with your VBScript application implementation.

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

##### ****CompareDocuments.vbs:**
    
```
' Create TextComparer object
Set comparer = CreateObject("Bytescout.PDFExtractor.TextComparer")
comparer.RegistrationName = "demo"
comparer.RegistrationKey = "demo"

'Compare documents
comparer.Compare "..\..\comparison1.pdf", "..\..\comparison2.pdf"

' Generate report
comparer.GenerateHtmlReport "report.html"

' Open output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "report.html", 1, false


```

<!-- code block end -->