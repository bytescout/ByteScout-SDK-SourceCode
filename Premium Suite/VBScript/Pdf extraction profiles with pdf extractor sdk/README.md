## pdf extraction profiles with pdf extractor sdk in VBScript with ByteScout Premium Suite

### Simple tutorial on how to do pdf extraction profiles with pdf extractor sdk in VBScript

ByteScout tutorials describe the stuff for programmers who use VBScript. Pdf extraction profiles with pdf extractor sdk in VBScript can be applied with ByteScout Premium Suite. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Save time on writing and testing code by using the code below and use it in your application. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. These VBScript sample examples can be used in one or many applications.

Trial version along with the source code samples for VBScript can be downloaded from our website

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

##### ****Profiles.vbs:**
    
```
' This example demonstrates the use of profiles. Profiles are set of properties 
' allowing to apply them to Extractor in any combination quickly. You can use 
' predefined profiles or create you own in JSON format like in this example.

' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"
extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample_ocr.pdf")

' Apply predefined profiles
extractor.Profiles = "scanned, no-layout"
' Extract text to file
extractor.SaveTextToFile("result1.txt")


extractor.Reset


' Load another document
extractor.LoadDocumentFromFile("..\..\sample_ocr.pdf")

' Load and apply custom profiles
extractor.LoadProfiles("profiles.json")
extractor.Profiles = "keep-formatting, ocr-forced-200dpi"
' Extract text to file
extractor.SaveTextToFile("result2.txt")

```

<!-- code block end -->