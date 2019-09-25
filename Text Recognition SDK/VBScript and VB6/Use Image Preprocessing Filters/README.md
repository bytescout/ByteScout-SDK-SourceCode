## How to use image preprocessing filters in VBScript and VB6 using ByteScout Text Recognition SDK

### Tutorial on how to use image preprocessing filters in VBScript and VB6

The sample source codes on this page shows how to use image preprocessing filters in VBScript and VB6. ByteScout Text Recognition SDK: the text recognition SDK to help with extraction of text using OCR from scanned images and documents. Supports English and non-Latin languages, can take PDF as input. It can use image preprocessing filters in VBScript and VB6.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout Text Recognition SDK. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. Enjoy writing a code with ready-to-use sample codes in VBScript and VB6.

Free trial version of ByteScout Text Recognition SDK is available on our website. Documentation and source code samples are included.

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

##### ****ImagePreprocessingFilters.vbs:**
    
```
' Create and activate TextRecognizer object
Set textRecognizer = CreateObject("ByteScout.TextRecognition.TextRecognizer")
textRecognizer.RegistrationName = "demo"
textRecognizer.RegistrationKey = "demo"

inputDocument = "..\..\skewed.png"
outputDocument = "result.txt"

' Load document (image or PDF)
textRecognizer.LoadDocument(inputDocument)

' Set the location of OCR language data files
textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\"

' Set OCR language.
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
' Find more language files at https://github.com/bytescout/ocrdata
textRecognizer.OCRLanguage = "eng" 


' Add deskew filter that automatically rotates the image to make the text horizontal.
' Note, it analyzes the left edge of scanned text. Any dark artifacts may prevent 
' the correct angle detection.
textRecognizer.ImagePreprocessingFilters.AddDeskew()

' Other filters that may be useful to improve recognition
' (note, the filters are applied in the order they were added):

' Improve image contrast.
'textRecognizer.ImagePreprocessingFilters.AddContrast()

' Apply gamma correction.
'textRecognizer.ImagePreprocessingFilters.AddGammaCorrection()

' Apply median filter. Helps to remove noise.
'textRecognizer.ImagePreprocessingFilters.AddMedian()

' Apply dilate filter. Helps to cure symbols erosion.
'textRecognizer.ImagePreprocessingFilters.AddDilate()

' Lines removers. Removing borders of some tables may improve the recognition.
'textRecognizer.ImagePreprocessingFilters.AddHorizontalLinesRemover()
'textRecognizer.ImagePreprocessingFilters.AddVerticalLinesRemover()


' Recognize text from all pages and save it to file
textRecognizer.SaveText(outputDocument)

WScript.Echo "Extracted text saved to " + outputDocument

Set recognizer = Nothing


```

<!-- code block end -->