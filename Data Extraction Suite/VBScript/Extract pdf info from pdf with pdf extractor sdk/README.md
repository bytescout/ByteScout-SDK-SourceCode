## How to extract pdf info from pdf with pdf extractor sdk in VBScript with ByteScout Data Extraction Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to extract pdf info from pdf with pdf extractor sdk in VBScript

An easy to understand guide on how to extract pdf info from pdf with pdf extractor sdk in VBScript with this source code sample. Want to extract pdf info from pdf with pdf extractor sdk in your VBScript app? ByteScout Data Extraction Suite is designed for it. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Data Extraction Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. This basic programming language sample code for VBScript will do the whole work for you to extract pdf info from pdf with pdf extractor sdk.

The trial version of ByteScout Data Extraction Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****ExtractInfo.vbs:**
    
```
' Create Bytescout.PDFExtractor.InfoExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.InfoExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

Dim info
info = "Author: " & extractor.Author & vbCrLf & _
       "Creator: " & extractor.Creator & vbCrLf & _
       "Producer: " & extractor.Producer & vbCrLf & _
       "Subject: " & extractor.Subject & vbCrLf & _
       "Title: " & extractor.Title & vbCrLf & _
       "CreationDate: " & extractor.CreationDate & vbCrLf & _
       "Keywords: " & extractor.Keywords & vbCrLf & _
       "Encrypted: " & extractor.Encrypted & vbCrLf & _
       "Bookmarks: " & extractor.Bookmarks & vbCrLf

MsgBox info

Set extractor = Nothing


```

<!-- code block end -->