## How to make searchable pdf and fix rotated pages with pdf extractor sdk in VBScript and ByteScout Premium Suite

### Learn to code in VBScript to make searchable pdf and fix rotated pages with pdf extractor sdk with this step-by-step tutorial

The sample source codes on this page shows how to make searchable pdf and fix rotated pages with pdf extractor sdk in VBScript. What is ByteScout Premium Suite? It is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to make searchable pdf and fix rotated pages with pdf extractor sdk in your VBScript application.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Premium Suite. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample VBScript codes.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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