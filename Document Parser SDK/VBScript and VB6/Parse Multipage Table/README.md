## How to parse multipage table in VBScript and VB6 with ByteScout Document Parser SDK

### Write code in VBScript and VB6 to parse multipage table with this step-by-step tutorial

Sample source code below will show you how to cope with a difficult task like parse multipage table in VBScript and VB6. ByteScout Document Parser SDK can parse multipage table. It can be used from VBScript and VB6. ByteScout Document Parser SDK is the customizable data extraction platform for batch data extraction from documents. Relies on special templates that can be created with no special technical skills required. Supports millions of documents as input and designed to handle multiple threads. Can output data as JSON, CSV, XML or custom format.

The SDK samples like this one below explain how to quickly make your application do parse multipage table in VBScript and VB6 with the help of ByteScout Document Parser SDK. This VBScript and VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout Document Parser SDK in VBScript and VB6 is also explained in the documentation included along with the product.

You can download free trial version of ByteScout Document Parser SDK from our website to see and try many others source code samples for VBScript and VB6.

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

##### **MultiPageTable-template1.yml:**
    
```
templateName: Multipage Table Test
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - Sample document with multi-page table
objects:
- name: total
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: TOTAL{{Spaces}}({{Number}})
    regex: true
    dataType: decimal
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: Item{{Spaces}}Description{{Spaces}}Price
      regex: true
    end:
      expression: TOTAL{{Spaces}}{{Number}}
      regex: true
    row:
      expression: '{{LineStart}}{{Spaces}}(?<itemNo>{{Digits}}){{Spaces}}(?<description>{{SentenceWithSingleSpaces}}){{Spaces}}(?<price>{{Number}}){{Spaces}}(?<qty>{{Digits}}){{Spaces}}(?<extPrice>{{Number}})'
      regex: true
    columns:
    - name: itemNo
      dataType: integer
    - name: description
      dataType: string
    - name: price
      dataType: decimal
    - name: qty
      dataType: integer
    - name: extPrice
      dataType: decimal
    multipage: true


```

<!-- code block end -->    

<!-- code block begin -->

##### **MultiPageTable-template2.yml:**
    
```
templateName: Multipage Table Test
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - Sample document with multi-page table
objects:
- name: total
  objectType: field
  fieldProperties:
    fieldType: regex
    expression: TOTAL{{Spaces}}({{Number}})
    regex: true
    dataType: decimal
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: Item{{Spaces}}Description{{Spaces}}Price
      regex: true
    end:
      expression: (Page {{Digits}} of {{Digits}})|(TOTAL{{Spaces}}{{Number}})
      regex: true
    left: 51
    right: 528
    columns:
    - x: 51
      name: itemNo
      dataType: integer
    - x: 102
      name: description
      dataType: string
    - x: 324
      name: price
      dataType: decimal
    - x: 396
      name: qty
      dataType: integer
    - x: 441
      name: extPrice
      dataType: decimal
    multipage: true


```

<!-- code block end -->    

<!-- code block begin -->

##### **ParseMultipageTable.vbs:**
    
```
' This example demonstrates parsing of multipage tables in two different approaches.
' See comments in the code of templates.

inputDocument = ".\MultiPageTable.pdf"
template1 = ".\MultiPageTable-template1.yml"
template2 = ".\MultiPageTable-template2.yml"


' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Loading template...
documentParser.AddTemplate(template1)

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "result1.json", 0

Set documentParser = Nothing


' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Loading template...
documentParser.AddTemplate(template2)

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "result2.json", 0


WScript.Echo "Parsed data saved as 'result1.json' and 'result2.json'."

Set documentParser = Nothing


```

<!-- code block end -->