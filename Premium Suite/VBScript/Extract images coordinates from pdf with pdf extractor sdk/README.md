## How to extract images coordinates from pdf with pdf extractor sdk in VBScript using ByteScout Premium Suite

### How to write a robust code in VBScript to extract images coordinates from pdf with pdf extractor sdk with this step-by-step tutorial

The sample shows instructions and algorithm of how to extract images coordinates from pdf with pdf extractor sdk and how to make it run in your VBScript application. Want to extract images coordinates from pdf with pdf extractor sdk in your VBScript app? ByteScout Premium Suite is designed for it. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Premium Suite. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Complete and detailed tutorials and documentation are available along with installed ByteScout Premium Suite if you'd like to learn more about the topic and the details of the API.

Our website gives trial version of ByteScout Premium Suite for free. It also includes documentation and source code samples.

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