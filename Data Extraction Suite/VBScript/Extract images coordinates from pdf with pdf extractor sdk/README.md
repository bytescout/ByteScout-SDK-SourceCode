## How to extract images coordinates from pdf with pdf extractor sdk in VBScript and ByteScout Data Extraction Suite

### If you want to learn more then this tutorial will show how to extract images coordinates from pdf with pdf extractor sdk in VBScript

Sample source code below will display you how to manage a complex task like extract images coordinates from pdf with pdf extractor sdk in VBScript. What is ByteScout Data Extraction Suite? It is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can help you to extract images coordinates from pdf with pdf extractor sdk in your VBScript application.

The following code snippet for ByteScout Data Extraction Suite works best when you need to quickly extract images coordinates from pdf with pdf extractor sdk in your VBScript application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

Our website gives trial version of ByteScout Data Extraction Suite for free. It also includes documentation and source code samples.

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

##### ****ExtractImageCoordinatesFromAllImages.vbs:**
    
```
' Create Bytescout.PDFExtractor.ImageExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.ImageExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

i = 0

' Initialize image enumeration
If extractor.GetFirstImage() Then
    Do
        ' display coordinates of the image
        MsgBox "Image #" & CStr(i) & vbCRLF & "Coordinates: " & CStr( extractor.GetCurrentImageRectangle_Left()) & ", " & _
            CStr( extractor.GetCurrentImageRectangle_Top()) & ", " & CStr( extractor.GetCurrentImageRectangle_Width()) & ", " & _
            CStr( extractor.GetCurrentImageRectangle_Height())
        i = i + 1
    Loop While extractor.GetNextImage() ' Advance image enumeration
End If

Set extractor = Nothing


```

<!-- code block end -->