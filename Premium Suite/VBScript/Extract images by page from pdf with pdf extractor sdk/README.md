## How to extract images by page from pdf with pdf extractor sdk in VBScript and ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to extract images by page from pdf with pdf extractor sdk in VBScript

The sample source code below will teach you how to extract images by page from pdf with pdf extractor sdk in VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can extract images by page from pdf with pdf extractor sdk in VBScript.

The SDK samples given below describe how to quickly make your application do extract images by page from pdf with pdf extractor sdk in VBScript with the help of ByteScout Premium Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Use of ByteScout Premium Suite in VBScript is also described in the documentation included along with the product.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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