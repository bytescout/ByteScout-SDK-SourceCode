## How to extract images from pdf with pdf extractor sdk in VBScript and ByteScout Premium Suite

### This code in VBScript shows how to extract images from pdf with pdf extractor sdk with this how to tutorial

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can extract images from pdf with pdf extractor sdk in VBScript.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to extract images from pdf with pdf extractor sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### ****ExtractAllImages.vbs:**
    
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
        outputFileName = "image" & i & ".png"
        ' Save image to file
        extractor.SaveCurrentImageToFile outputFileName
        i = i + 1
    Loop While extractor.GetNextImage() ' Advance image enumeration
End If

' Open first output image in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "image0.png", 1, false
Set shell = Nothing

Set extractor = Nothing


```

<!-- code block end -->