## How to extract image coordinates by page from pdf with pdf extractor sdk in VBScript with ByteScout Data Extraction Suite

### If you want to learn more then this tutorial will show how to extract image coordinates by page from pdf with pdf extractor sdk in VBScript

Sample source code below will display you how to manage a complex task like extract image coordinates by page from pdf with pdf extractor sdk in VBScript. Want to extract image coordinates by page from pdf with pdf extractor sdk in your VBScript app? ByteScout Data Extraction Suite is designed for it. ByteScout Data Extraction Suite is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

This prolific sample source code in VBScript for ByteScout Data Extraction Suite contains various functions and other necessary options you should do calling the API to extract image coordinates by page from pdf with pdf extractor sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Want to see how it works with your data then code testing will allow the function to be tested and work properly.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### ****ExtractImagesCoordinatesByPages.vbs:**
    
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
            ' display coordinates of the image
            MsgBox "Image #" & CStr(j) & " on page #" & CStr(i) & vbCRLF & "Coordinates: " & _
                CStr( extractor.GetCurrentImageRectangle_Left()) & ", " & CStr( extractor.GetCurrentImageRectangle_Top()) & ", " & _
                CStr( extractor.GetCurrentImageRectangle_Width()) & ", " & CStr( extractor.GetCurrentImageRectangle_Height())
            j = j + 1
        Loop While extractor.GetNextImage() ' Advance image enumeration
    End If
Next

Set extractor = Nothing


```

<!-- code block end -->