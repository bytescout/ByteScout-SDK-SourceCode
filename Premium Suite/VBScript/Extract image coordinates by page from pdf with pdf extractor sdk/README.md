## How to extract image coordinates by page from pdf with pdf extractor sdk in VBScript using ByteScout Premium Suite

### This code in VBScript shows how to extract image coordinates by page from pdf with pdf extractor sdk with this how to tutorial

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to extract image coordinates by page from pdf with pdf extractor sdk with VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guidelines and the code below will help you quickly learn how to extract image coordinates by page from pdf with pdf extractor sdk. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

You can download free trial version of ByteScout Premium Suite from our website with this and other source code samples for VBScript.

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