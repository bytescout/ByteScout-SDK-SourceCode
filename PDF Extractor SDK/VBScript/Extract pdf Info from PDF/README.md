## How to extract pdf info from PDF in VBScript and ByteScout PDF Extractor SDK

### The tutorial below will demonstrate how to extract pdf info from PDF in VBScript

Source code documentation samples provide quick and easy way to add a required functionality into your application. ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker. It can be used to extract pdf info from PDF using VBScript.

Fast application programming interfaces of ByteScout PDF Extractor SDK for VBScript plus the instruction and the code below will help you quickly learn how to extract pdf info from PDF. Follow the instructions from the scratch to work and copy the VBScript code. Further enhancement of the code will make it more vigorous.

ByteScout PDF Extractor SDK free trial version is available on our website. VBScript and other programming languages are supported.

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