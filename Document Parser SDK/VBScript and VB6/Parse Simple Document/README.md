## How to parse simple document in VBScript and VB6 using ByteScout Document Parser SDK

### This code in VBScript and VB6 shows how to parse simple document with this how to tutorial

These sample source codes on this page below are demonstrating how to parse simple document in VBScript and VB6. Want to parse simple document in your VBScript and VB6 app? ByteScout Document Parser SDK is designed for it. ByteScout Document Parser SDK is the template based data extraction engine can process thousands and millions of documents per day based on templates. Can work online and offline for privacy focused tasks. Templates can be supported and updated without any programming or technical knowledge required. Output is generated in JSON, CSV, XML and custom format if required.

Fast application programming interfaces of ByteScout Document Parser SDK for VBScript and VB6 plus the instruction and the code below will help you quickly learn how to parse simple document. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Implementing VBScript and VB6 application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Free trial version of ByteScout Document Parser SDK is available for download from our website. Get it to try other source code samples for VBScript and VB6.

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

##### **AmazonAWS.yml:**
    
```
templateName: Amazon Web Services Invoice
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - Amazon Web Services
  - ATTN
  - Invoice
objects:
- name: total
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: TOTAL AMOUNT DUE ON{{Anything}}{{Dollar}}({{Number}})
    regex: true
    dataType: decimal
- name: subTotal
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: '{{LineStart}}{{Spaces}}Charges{{Spaces}}{{Dollar}}({{Number}})'
    regex: true
    dataType: decimal
- name: dateIssued
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: Invoice Date:{{Spaces}}({{Anything}}){{LineEnd}}
    regex: true
    dataType: date
    dateFormat: MMMM d , yyyy
- name: invoiceId
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: Invoice Number:{{Spaces}}({{Digits}})
    regex: true
- name: companyName
  objectType: field
  fieldProperties:
    fieldType: static
    expression: Amazon Web Services, Inc.
    regex: true
- name: companyWebsite
  objectType: field
  fieldProperties:
    fieldType: static
    expression: aws.amazon.com
    regex: true
- name: billTo
  objectType: field
  fieldProperties:
    fieldType: rectangle
    expression: Bill to Address:{{ToggleSingleLineMode}}({{AnythingGreedy}})
    regex: true
    rectangle:
    - 33
    - 115.5
    - 213.75
    - 72.75
    pageIndex: 0
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
      expression: '{{LineStart}}{{Spaces}}Detail{{LineEnd}}'
      regex: true
    end:
      expression: '{{EndOfPage}}'
      regex: true
    row:
      expression: '{{LineStart}}{{Spaces}}(?<description>{{SentenceWithSingleSpaces}}){{Spaces}}{{Dollar}}(?<unitPrice>{{Number}}){{LineEnd}}'
      regex: true
    columns:
    - name: unitPrice
      dataType: decimal


```

<!-- code block end -->    

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

##### **GeneralExample.vbs:**
    
```
' This example demonstrates document data parsing to JSON and YAML formats.

template1 = ".\DigitalOcean.yml"
template2 = ".\AmazonAWS.yml"

inputDocument1 = ".\DigitalOcean.pdf"
inputDocument2 = ".\AmazonAWS.pdf"


' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Loading templates...
documentParser.AddTemplate(template1)
documentParser.AddTemplate(template2)

' Parse document data in JSON format
documentParser.ParseDocument inputDocument1, "output1.json", 0 ' 0 = OutputFormat.JSON

' Parse document data in YAML format
documentParser.ParseDocument inputDocument2, "output2.yaml", 1 ' 1 = OutputFormat.YAML

WScript.Echo "Parsed data saved as 'output1.json' and 'output2.yaml'."

Set documentParser = Nothing


```

<!-- code block end -->