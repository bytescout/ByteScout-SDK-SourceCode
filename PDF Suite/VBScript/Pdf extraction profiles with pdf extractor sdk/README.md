## pdf extraction profiles with pdf extractor sdk in VBScript using ByteScout PDF Suite

### Learn pdf extraction profiles with pdf extractor sdk in VBScript

This page helps you to learn from code samples for programming in VBScript. ByteScout PDF Suite was created to assist pdf extraction profiles with pdf extractor sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

The below SDK samples describe how to quickly make your application do pdf extraction profiles with pdf extractor sdk in VBScript with the help of ByteScout PDF Suite. To use pdf extraction profiles with pdf extractor sdk in your VBScript project or application just copy & paste the code and then run your app! This basic programming language sample code for VBScript will do the whole work for you in implementing pdf extraction profiles with pdf extractor sdk in your app.

On our website you may get trial version of ByteScout PDF Suite for free. Source code samples are included to help you with your VBScript application.

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