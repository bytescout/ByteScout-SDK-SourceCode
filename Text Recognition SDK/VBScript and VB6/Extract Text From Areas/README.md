## How to extract text from areas in VBScript and VB6 using ByteScout Text Recognition SDK

### How to extract text from areas in VBScript and VB6

ByteScout tutorials are designed to explain the code for both VBScript and VB6 beginners and advanced programmers. ByteScout Text Recognition SDK can extract text from areas. It can be used from VBScript and VB6. ByteScout Text Recognition SDK is the SDK designed to help developers in quick implementation of high quality OCR text recognition from scanned images and pdf.

This code snippet below for ByteScout Text Recognition SDK works best when you need to quickly extract text from areas in your VBScript and VB6 application. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. Further enhancement of the code will make it more vigorous.

Download free trial version of ByteScout Text Recognition SDK from our website with this and other source code samples for VBScript and VB6.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Text%20Recognition%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Text%20Recognition%20SDK%20Question) 

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

##### ****ExtractFromAreas.vbs:**
    
```
' Create and activate TextRecognizer object
Set textRecognizer = CreateObject("ByteScout.TextRecognition.TextRecognizer")
textRecognizer.RegistrationName = "demo"
textRecognizer.RegistrationKey = "demo"

Set comHelpers = textRecognizer.ComHelpers

inputDocument = "..\..\areas-sample.pdf"
pageIndex = 0
outputDocument = "result.txt"

' Load document (image or PDF)
textRecognizer.LoadDocument(inputDocument)

' Set the location of OCR language data files
textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\"

' Set OCR language.
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
' Find more language files at https://github.com/bytescout/ocrdata
textRecognizer.OCRLanguage = "eng" 

' Get page size (in pixels). Size of PDF document is computed from PDF Points 
' and the rendering resoultion specified by `textRecognizer.PDFRenderingResolution` (default 300 DPI)
Dim pageWidth, pageHeight
pageWidth = textRecognizer.GetPageWidth(pageIndex)
pageHeight = textRecognizer.GetPageHeight(pageIndex)

' Add area of interest as a rectangle at the top-right corner of the page
textRecognizer.RecognitionAreas.Add pageWidth / 2, 0, pageWidth / 2, 300
' Add area of interest as a rectangle at the bottom-left corner of the page,
' and indicate it should be rotated at 90 deg
textRecognizer.RecognitionAreas.Add 0, pageHeight / 2, 300, pageHeight / 2, comHelpers.AreaRotation_Rotate90FlipNone

' Now you can get recognized text for further analysis as a list of objects 
' containing coordinates, object kind, confidence.
Set ocrObjectList = textRecognizer.GetOCRObjects(pageIndex)
For Each ocrObject in OCRObjectList
    WScript.Echo ocrObject.Text & " [" & ocrObject.X & ", " & ocrObject.Y & ", " & ocrObject.Width & ", " & ocrObject.Height & "] : " & ocrObject.Confidence
Next

' ... or you can save recognized text pieces to file
textRecognizer.KeepTextFormatting = False ' save without formatting
textRecognizer.SaveText outputDocument, pageIndex, pageIndex


WScript.Echo "Extracted text saved to " + outputDocument

Set recognizer = Nothing


```

<!-- code block end -->