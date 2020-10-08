## How to create custom template in VBScript and VB6 using ByteScout Document Parser SDK

### This code in VBScript and VB6 shows how to create custom template with this how to tutorial

Every ByteScout tool contains example VBScript and VB6 source codes that you can find here or in the folder with installed ByteScout product. ByteScout Document Parser SDK: the customizable data extraction platform for batch data extraction from documents. Relies on special templates that can be created with no special technical skills required. Supports millions of documents as input and designed to handle multiple threads. Can output data as JSON, CSV, XML or custom format. It can create custom template in VBScript and VB6.

This rich sample source code in VBScript and VB6 for ByteScout Document Parser SDK includes the number of functions and options you should do calling the API to create custom template. In your VBScript and VB6 project or application you may simply copy & paste the code and then run your app! You can use these VBScript and VB6 sample examples in one or many applications.

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

##### **CustomTemplate.vbs:**
    
```
' This example demonstrates data parsing from an invoice using the custom template.

customTemplate = ".\SampleTemplate.yml"
inputDocument = ".\SampleInvoice.pdf"

' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Load custom template
documentParser.AddTemplate customTemplate

' Parse invoice data in JSON format
documentParser.ParseDocument inputDocument, "output1.json", 0 ' 0 = OutputFormat.JSON


WScript.Echo "Parsed data saved as 'output1.json'."

Set documentParser = Nothing


```

<!-- code block end -->    

<!-- code block begin -->

##### **SampleTemplate.yml:**
    
```
templateName: My Custom Template
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - Your Company Name
  - Invoice No\.
  - TOTAL
objects:
- name: total
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: TOTAL{{Spaces}}{{Number}}
    dataType: decimal
    pageIndex: 0
- name: dateIssued
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: Invoice Date {{SmartDate}}
    dataType: date
    dateFormat: auto-mdy
    pageIndex: 0
- name: invoiceId
  objectType: field
  fieldProperties:
    fieldType: macros
    expression: '{{Number}}'
    dataType: string
    pageIndex: 0
- name: companyName
  objectType: field
  fieldProperties:
    fieldType: static
    expression: Vendor Company
    regex: true
    pageIndex: 0
- name: billTo
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 32.25
    - 150
    - 348
    - 70.5
    pageIndex: 0
- name: notes
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 32.25
    - 227.25
    - 531
    - 47.25
    pageIndex: 0
- name: table1
  objectType: table
  tableProperties:
    start:
      expression: Item\s+Quantity\s+Price\s+Total
      regex: true
    end:
      expression: TOTAL
      regex: true
    subItemStart:
      regex: true
    subItemEnd:
      regex: true
    row:
      expression: ^\s*(?<description>\w+.*)(?<quantity>\d+)\s+(?<unitPrice>\d+\.\d{2})\s+(?<itemTotal>\d+\.\d{2})\s*$
      regex: true


```

<!-- code block end -->