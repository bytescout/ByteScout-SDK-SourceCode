## How to make searchable pdf and fix rotated pages with pdf extractor sdk in VBScript with ByteScout Data Extraction Suite

### Learn to make searchable pdf and fix rotated pages with pdf extractor sdk in VBScript

The documentation is designed for a specific purpose to help you to apply the features on your side. Want to make searchable pdf and fix rotated pages with pdf extractor sdk in your VBScript app? ByteScout Data Extraction Suite is designed for it. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

The SDK samples given below describe how to quickly make your application do make searchable pdf and fix rotated pages with pdf extractor sdk in VBScript with the help of ByteScout Data Extraction Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Complete and detailed tutorials and documentation are available along with installed ByteScout Data Extraction Suite if you'd like to learn more about the topic and the details of the API.

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

##### ****MakeSearchablePDFAndFixRotatingPages.vbs:**
    
```
' Create Bytescout.PDFExtractor.SearchablePDFMaker object
Set searchablePDFMaker = CreateObject("Bytescout.PDFExtractor.SearchablePDFMaker")
searchablePDFMaker.RegistrationName = "demo"
searchablePDFMaker.RegistrationKey = "demo"

' Load sample PDF document
searchablePDFMaker.LoadDocumentFromFile("..\..\sample_ocr_with_rotatedPage.pdf")

' Set the location of OCR language data files
searchablePDFMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata"
			
' Set OCR language
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder.
searchablePDFMaker.OCRLanguage = "eng"  
' Find more language files at https://github.com/bytescout/ocrdata

' Set PDF document rendering resolution
searchablePDFMaker.OCRResolution = 300

' Detect page rotation
searchablePDFMaker.OCRDetectPageRotation = true

' Process the document
searchablePDFMaker.MakePDFSearchable("result.pdf")

WScript.Echo "Searchable document saved as 'result.pdf'."
```

<!-- code block end -->