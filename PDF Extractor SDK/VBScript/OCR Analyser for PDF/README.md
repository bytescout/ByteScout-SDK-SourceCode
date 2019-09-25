## OCR analyser for PDF in VBScript and ByteScout PDF Extractor SDK

### OCR analyser for PDF in VBScript

Here you may find thousands pre-made source code pieces for easy implementation in your own programming VBScript projects. ByteScout PDF Extractor SDK was made to help with OCR analyser for PDF in VBScript. ByteScout PDF Extractor SDK is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout PDF Extractor SDK. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. VBScript application implementation typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Free trial version of ByteScout PDF Extractor SDK is available on our website. Get it to try other samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




<!-- code block begin -->

##### ****PerformOcrAnalysisAndExtractText.vbs:**
    
```
' This example demonstrates the use of OCR Analyser - a tooling class for analysis of scanned documents
' in PDF or raster image formats to find best parameters for Optical Character Recognition (OCR) that
' provide highest recognition quality.


' Input document
inputDocument = "..\..\sample_ocr.pdf"

' Document page index
pageIndex = 0

' Location of OCR language data files
ocrLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

' OCR language
ocrLanguage = "eng" ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
' Find more language files at https://github.com/bytescout/ocrdata


' Create OCRAnalyzer object and activate it with your registration information
Set ocrAnalyzer = CreateObject("Bytescout.PDFExtractor.OCRAnalyzer")
ocrAnalyzer.RegistrationName = "demo"
ocrAnalyzer.RegistrationKey = "demo"

' Load document to OCRAnalyzer
ocrAnalyzer.LoadDocumentFromFile(inputDocument)

' Setup OCRAnalyzer
ocrAnalyzer.OCRLanguage = ocrLanguage
ocrAnalyzer.OCRLanguageDataFolder = ocrLanguageDataFolder

WScript.Echo "Starting the OCR analysis. Click OK and wait, it may last long." & outputDocument

' Perform analysis and get results
Set analysisResults = ocrAnalyzer.AnalyzeByOCRConfidence(pageIndex)


' Now extract page text using detected OCR parameters

outputDocument = ".\result.txt"

' Create TextExtractor object
Set textExtractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
textExtractor.RegistrationName = "demo"
textExtractor.RegistrationKey = "demo"

' Load document to TextExtractor
textExtractor.LoadDocumentFromFile(inputDocument)

' Setup TextExtractor
textExtractor.OCRMode = 1 ' OCRMode.Auto
textExtractor.OCRLanguageDataFolder = ocrLanguageDataFolder
textExtractor.OCRLanguage = ocrLanguage

' Apply analysys results to TextExtractor instance
ocrAnalyzer.ApplyResults (analysisResults), (textExtractor)

' Save extracted text to file
textExtractor.SaveTextToFile(outputDocument)


WScript.Echo "Extracted text saved to " & outputDocument


Set textExtractor = Nothing
Set ocrAnalyzer = Nothing


```

<!-- code block end -->