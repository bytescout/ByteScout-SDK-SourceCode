## ocr analyser for pdf with pdf extractor sdk in VBScript and ByteScout PDF Suite

### ocr analyser for pdf with pdf extractor sdk in VBScript

ByteScout tutorials describe the stuff for programmers who use VBScript. ByteScout PDF Suite was made to help with ocr analyser for pdf with pdf extractor sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Save time on writing and testing code by using the code below and use it in your application. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample VBScript codes to implement ocr analyser for pdf with pdf extractor sdk using ByteScout PDF Suite.

Trial version can be downloaded from our website for free. It contains this and other source code samples for VBScript.

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
ocrLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best_best\"

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