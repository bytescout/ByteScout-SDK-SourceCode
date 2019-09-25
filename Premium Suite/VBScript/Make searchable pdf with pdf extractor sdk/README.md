## How to make searchable pdf with pdf extractor sdk in VBScript with ByteScout Premium Suite

### If you want to learn more then this tutorial will show how to make searchable pdf with pdf extractor sdk in VBScript

On this page you will learn from code samples for programming in VBScript.Writing of the code to make searchable pdf with pdf extractor sdk in VBScript can be executed by programmers of any level using ByteScout Premium Suite. Want to make searchable pdf with pdf extractor sdk in your VBScript app? ByteScout Premium Suite is designed for it. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to make searchable pdf with pdf extractor sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

If you want to try other source code samples then the free trial version of ByteScout Premium Suite is available for download from our website. Just try other source code samples for VBScript.

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

##### ****MakeSearchablePDF.vbs:**
    
```
' Create Bytescout.PDFExtractor.SearchablePDFMaker object
Set searchablePDFMaker = CreateObject("Bytescout.PDFExtractor.SearchablePDFMaker")
searchablePDFMaker.RegistrationName = "demo"
searchablePDFMaker.RegistrationKey = "demo"

' Load sample PDF document
searchablePDFMaker.LoadDocumentFromFile("..\..\sample_ocr.pdf")

' Set the location of OCR language data files
searchablePDFMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata"
			
' Set OCR language
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder.
searchablePDFMaker.OCRLanguage = "eng"  
' Find more language files at https://github.com/bytescout/ocrdata

' Set PDF document rendering resolution
searchablePDFMaker.OCRResolution = 300

' Process the document
searchablePDFMaker.MakePDFSearchable("result.pdf")

WScript.Echo "Searchable document saved as 'result.pdf'."
```

<!-- code block end -->