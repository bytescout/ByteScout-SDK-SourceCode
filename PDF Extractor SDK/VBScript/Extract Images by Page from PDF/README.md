## How to extract images by page from PDF in VBScript with ByteScout PDF Extractor SDK

### This code in VBScript shows how to extract images by page from PDF with this how to tutorial

Every ByteScout tool contains example VBScript source codes that you can find here or in the folder with installed ByteScout product. ByteScout PDF Extractor SDK can extract images by page from PDF. It can be used from VBScript. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

VBScript code samples for VBScript developers help to speed up coding of your application when using ByteScout PDF Extractor SDK. In your VBScript project or application you may simply copy & paste the code and then run your app! Test VBScript sample code examples whether they respond your needs and requirements for the project.

Our website provides trial version of ByteScout PDF Extractor SDK for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




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