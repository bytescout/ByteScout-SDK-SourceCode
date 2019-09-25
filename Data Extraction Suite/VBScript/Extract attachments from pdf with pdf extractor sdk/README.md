## How to extract attachments from pdf with pdf extractor sdk in VBScript with ByteScout Data Extraction Suite

### Learn to code in VBScript to extract attachments from pdf with pdf extractor sdk with this step-by-step tutorial

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. What is ByteScout Data Extraction Suite? It is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can help you to extract attachments from pdf with pdf extractor sdk in your VBScript application.

This prolific sample source code in VBScript for ByteScout Data Extraction Suite contains various functions and other necessary options you should do calling the API to extract attachments from pdf with pdf extractor sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample codes in VBScript.

ByteScout provides the free trial version of ByteScout Data Extraction Suite along with the documentation and source code samples.

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

##### ****ExtractAttachments.vbs:**
    
```
' Create Bytescout.PDFExtractor.extractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.AttachmentExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document with embedded attachments
extractor.LoadDocumentFromFile("..\..\attachments.pdf")

' Iterate through attachments and save them
For i = 0 To extractor.Count - 1
    ' Save file to current folder with original name
    extractor.Save i, extractor.GetFileName(i)
Next

MsgBox "Done: " & CStr(extractor.Count) & " attachments extracted"

Set extractor = Nothing


```

<!-- code block end -->