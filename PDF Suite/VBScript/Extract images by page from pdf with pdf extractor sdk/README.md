## How to extract images by page from pdf with pdf extractor sdk in VBScript and ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to extract images by page from pdf with pdf extractor sdk in VBScript

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can be applied to extract images by page from pdf with pdf extractor sdk using VBScript.

The SDK samples given below describe how to quickly make your application do extract images by page from pdf with pdf extractor sdk in VBScript with the help of ByteScout PDF Suite.  Simply copy and paste in your VBScript project or application you and then run your app! Further improvement of the code will make it more robust.

You can download free trial version of ByteScout PDF Suite from our website with this and other source code samples for VBScript.

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

##### ****ExtractImagesByPages.vbs:**
    
```
' Create Bytescout.PDFExtractor.ImageExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.ImageExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

' Get page count
pageCount = extractor.GetPageCount()
        
' Extract images from each page
For i = 0 To pageCount - 1
    j = 0
    ' Initialize page images enumeration
    If extractor.GetFirstPageImage(i) Then
        Do
            outputFileName = "page" & i & "image" & j & ".png"
            ' Save image to file
            extractor.SaveCurrentImageToFile outputFileName
            j = j + 1
        Loop While extractor.GetNextImage() ' Advance image enumeration
    End If
Next

' Open first output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "page0image0.png", 1, false
Set shell = Nothing

Set extractor = Nothing


```

<!-- code block end -->