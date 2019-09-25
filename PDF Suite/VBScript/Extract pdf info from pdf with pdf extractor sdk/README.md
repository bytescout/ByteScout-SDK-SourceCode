## How to extract pdf info from pdf with pdf extractor sdk in VBScript with ByteScout PDF Suite

### Learn to code in VBScript to extract pdf info from pdf with pdf extractor sdk with this step-by-step tutorial

The coding instructions are formulated to help you to try-out the features without the requirement to write your own code. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can extract pdf info from pdf with pdf extractor sdk in VBScript.

This prolific sample source code in VBScript for ByteScout PDF Suite contains various functions and other necessary options you should do calling the API to extract pdf info from pdf with pdf extractor sdk.  Simply copy and paste in your VBScript project or application you and then run your app! If you want to use these VBScript sample examples in one or many applications then they can be used easily.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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