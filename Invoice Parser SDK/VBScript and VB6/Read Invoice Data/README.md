## How to read invoice data in VBScript and VB6 and ByteScout Invoice Parser SDK

### This code in VBScript and VB6 shows how to read invoice data with this how to tutorial

The sample shows steps and algorithm of how to read invoice data and how to make it work in your VBScript and VB6 application. ByteScout Invoice Parser SDK is the invoices processor engine that comes with built-in support for invoices from thousands of companies. Automatically detects company that issued invoice, extracts invoice number, date, total amount to be paid. Constantly updated to support invoices from new companies. Supports batch processing of invoices with JSON, CSV, XML output. It can be used to read invoice data using VBScript and VB6.

VBScript and VB6 code samples for VBScript and VB6 developers help to speed up coding of your application when using ByteScout Invoice Parser SDK. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Test VBScript and VB6 sample code examples whether they respond your needs and requirements for the project.

Free trial version of ByteScout Invoice Parser SDK is available for download from our website. Get it to try other source code samples for VBScript and VB6.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Invoice%20Parser%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Invoice%20Parser%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=nVANfuA4Xh0](https://www.youtube.com/watch?v=nVANfuA4Xh0)




<!-- code block begin -->

##### ****GeneralExample.vbs:**
    
```
' This example demonstrates invoice data parsing to JSON and YAML formats.

inputDocument1 = "..\..\DigitalOcean.pdf"
inputDocument2 = "..\..\AmazonAWS.pdf"

' Create InvoiceParser object
Set invoiceParser = CreateObject("Bytescout.InvoiceParser.InvoiceParser")
invoiceParser.RegistrationName = "demo"
invoiceParser.RegistrationKey = "demo"

' Parse invoice data in JSON format
invoiceParser.ParseDocument inputDocument1, "output1.json", 0 ' 0 = OutputFormat.JSON

' Parse invoice data in YAML format
invoiceParser.ParseDocument inputDocument2, "output2.yaml", 1 ' 1 = OutputFormat.YAML

WScript.Echo "Parsed data saved as 'output1.json' and 'output2.yaml'."

Set invoiceParser = Nothing


```

<!-- code block end -->