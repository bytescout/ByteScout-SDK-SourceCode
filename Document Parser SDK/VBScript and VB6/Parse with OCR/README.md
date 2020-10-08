## How to parse with OCR in VBScript and VB6 with ByteScout Document Parser SDK

### The tutorial shows how to parse with OCR in VBScript and VB6

Parse with OCR is easy to implement in VBScript and VB6 if you use these source codes below. ByteScout Document Parser SDK is the customizable data extraction platform for batch data extraction from documents. Relies on special templates that can be created with no special technical skills required. Supports millions of documents as input and designed to handle multiple threads. Can output data as JSON, CSV, XML or custom format. It can be used to parse with OCR using VBScript and VB6.

This code snippet below for ByteScout Document Parser SDK works best when you need to quickly parse with OCR in your VBScript and VB6 application. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample codes in VBScript and VB6.

Download free trial version of ByteScout Document Parser SDK from our website with this and other source code samples for VBScript and VB6.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Document%20Parser%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Document%20Parser%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=MG5FfTWWSVE](https://www.youtube.com/watch?v=MG5FfTWWSVE)




<!-- code block begin -->

##### **DigitalOcean.yml:**
    
```
templateName: DigitalOcean Invoice
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - DigitalOcean
  - 101 Avenue of the Americas
  - Invoice Number
objects:
- name: companyName
  objectType: field
  fieldProperties:
    fieldType: static
    expression: DigitalOcean
    regex: true
- name: invoiceId
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: 'Invoice Number: ({{Digits}})'
    regex: true
- name: dateIssued
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: 'Date Issued: ({{SmartDate}})'
    regex: true
    dataType: date
    dateFormat: auto-mdy
- name: total
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: 'Total: {{Dollar}}({{Number}})'
    regex: true
    dataType: decimal
- name: currency
  objectType: field
  fieldProperties:
    fieldType: static
    expression: USD
    regex: true
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: Description{{Spaces}}Hours
      regex: true
    end:
      expression: 'Total:'
      regex: true
    row:
      expression: '{{LineStart}}{{Spaces}}(?<description>{{SentenceWithSingleSpaces}}){{Spaces}}(?<hours>{{Digits}}){{Spaces}}(?<start>{{2Digits}}{{Minus}}{{2Digits}}{{Space}}{{2Digits}}{{Colon}}{{2Digits}}){{Spaces}}(?<end>{{2Digits}}{{Minus}}{{2Digits}}{{Space}}{{2Digits}}{{Colon}}{{2Digits}}){{Spaces}}{{Dollar}}(?<unitPrice>{{Number}})'
      regex: true
    columns:
    - name: hours
      dataType: integer
    - name: unitPrice
      dataType: decimal


```

<!-- code block end -->    

<!-- code block begin -->

##### **ParseWithOCR.vbs:**
    
```
' This example demonstrates parsing of scanned documents
' using the Optical Character Recognition (OCR).

template = ".\DigitalOcean.yml"
inputDocument = ".\DigitalOcean-scanned.jpg"


' Create and activate DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Enable Optical Character Recognition (OCR) in Auto mode
' (DocumentParser automatically detects if OCR Is required).
documentParser.OCRMode = 1 ' OCRMode.Auto

' Set PDF document rendering resolution
documentParser.OCRResolution = 300

' Set the location of OCR language data files
documentParser.OCRLanguageDataFolder = "c:\Program Files\ByteScout Document Parser SDK\ocrdata"

' Set OCR language
' "eng" for english, "deu" for German, "fra" for French, etc. - according to files in "ocrdata" folder
documentParser.OCRLanguage = "eng"
' Find more language files at https://github.com/bytescout/ocrdata

' Note: The OCRLanguage can be overridden in a template. 
' See the Template Creation Guide.



' You can also apply various preprocessing filters
' to improve the recognition on low-quality scans.

' Automatically deskew skewed scans
'documentParser.OCRImagePreprocessingFilters.AddDeskew()

' Remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
'documentParser.OCRImagePreprocessingFilters.AddVerticalLinesRemover()
'documentParser.OCRImagePreprocessingFilters.AddHorizontalLinesRemover()

' Repair broken letters
'documentParser.OCRImagePreprocessingFilters.AddDilate()

' Remove noise
'documentParser.OCRImagePreprocessingFilters.AddMedian()

' Apply Gamma Correction
'documentParser.OCRImagePreprocessingFilters.AddGammaCorrection(1.4)

' Add Contrast
'documentParser.OCRImagePreprocessingFilters.AddContrast(20)



' Load template
documentParser.AddTemplate(template)

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "output.json", 0 ' 0 = OutputFormat.JSON

WScript.Echo "Parsed data saved as 'output.json'"

Set documentParser = Nothing


```

<!-- code block end -->