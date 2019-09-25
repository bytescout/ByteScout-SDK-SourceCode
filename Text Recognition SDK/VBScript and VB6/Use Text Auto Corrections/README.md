## How to use text auto corrections in VBScript and VB6 and ByteScout Text Recognition SDK

### Tutorial on how to use text auto corrections in VBScript and VB6

The sample shows steps and algorithm of how to use text auto corrections and how to make it work in your VBScript and VB6 application. Want to use text auto corrections in your VBScript and VB6 app? ByteScout Text Recognition SDK is designed for it. ByteScout Text Recognition SDK is the software development kit for automatic text recognition and OCR from pdf documents and images. Can recognize English and non-English languages.

Fast application programming interfaces of ByteScout Text Recognition SDK for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to use text auto corrections. Just copy and paste the code into your VBScript and VB6 application’s code and follow the instruction. Detailed tutorials and documentation are available along with installed ByteScout Text Recognition SDK if you'd like to dive deeper into the topic and the details of the API.

ByteScout Text Recognition SDK free trial version is available on our website. VBScript and VB6 and other programming languages are supported.

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

##### ****AutoCorrections.vbs:**
    
```
' Create and activate TextRecognizer object
Set textRecognizer = CreateObject("ByteScout.TextRecognition.TextRecognizer")
textRecognizer.RegistrationName = "demo"
textRecognizer.RegistrationKey = "demo"

inputDocument = "..\..\bad-quality.png"
outputDocument = "result.txt"

' Load document (image or PDF)
textRecognizer.LoadDocument(inputDocument)

' Set the location of OCR language data files
textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_fast\"

' Set OCR language.
' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
' Find more language files at https://github.com/bytescout/ocrdata
textRecognizer.OCRLanguage = "eng" 


' Add error corrections that will be applied after the recognition.
textRecognizer.Corrections.Add "Tut ", "Test "
textRecognizer.Corrections.Add "Recog\w{1,}on", "Recognition", True


' Recognize text from all pages and save it to file
textRecognizer.SaveText(outputDocument)

WScript.Echo "Extracted text saved to " + outputDocument

Set recognizer = Nothing


```

<!-- code block end -->