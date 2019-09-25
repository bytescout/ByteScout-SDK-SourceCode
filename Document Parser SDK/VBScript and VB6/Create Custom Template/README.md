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
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=MG5FfTWWSVE](https://www.youtube.com/watch?v=MG5FfTWWSVE)




<!-- code block begin -->

##### ****CustomTemplate.vbs:**
    
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

##### ****SampleTemplate.yml:**
    
```
---
templateVersion: 1
sourceId: My Custom Template

detectionRules:
  # Few regex expressions uniquely identifying the document design.
  # Don't forget to escape special characters.
  keywords:
  - Your Company Name
  - Invoice No\.
  - TOTAL

# Expressions to extract distinct fields.
# Last matching group or "<value>" group will be passed to result.
fields:
  total:
    expression: TOTAL\s+(\d+\.\d+)
    type: decimal
  dateIssued:
    expression: Invoice Date (\d{2}/\d{2}/\d{4})
    # If type is dateTime and dateFormat property is specified
    # the date will be converted to universal time by the specified format.
    type: dateTime
    dateFormat: MM/dd/yyyy
  invoiceId:
    expression: Invoice No. (\d+)
  # Static field that will be passed to result unchanged.
  sourceName:
    expression: Vendor Company
    static: true
  # Couple of fixed rectangular fields. 
  # You can use "Template Editor" application to add them with ease.
  billTo:
    # Rectangle coordinates sequence: x, y, width, height.
    rect:
    - 32.25
    - 150
    - 348
    - 70.5
  notes:
    rect:
    - 32.25
    - 227.25
    - 531
    - 47.25
    # Optional page index parameter (zero-based) if you need to extract from specific page.
    pageIndex: 0

# Table data extraction.
tables:
- name: table1
  start:
    # Table start after header row "Item  Quantity  Price  Total".
    expression: Item\s+Quantity\s+Price\s+Total
  end:
    # Table rows last until "TOTAL" keyword.
    expression: TOTAL
  row:
    # Regex for table rows extraction.
    expression: ^\s*(?<description>\w+.*)(?<quantity>\d+)\s+(?<unitPrice>\d+\.\d{2})\s+(?<itemTotal>\d+\.\d{2})\s*$
  types:
    # Column datatypes. Names correspond to regex matching groups.
    unitPrice: decimal
    itemTotal: decimal

options:
  # multipage - set 'true' if table data can continue on following pages.
  multipage: false
```

<!-- code block end -->