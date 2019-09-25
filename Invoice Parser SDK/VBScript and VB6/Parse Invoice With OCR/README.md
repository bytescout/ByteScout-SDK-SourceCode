## How to parse invoice with OCR in VBScript and VB6 using ByteScout Invoice Parser SDK

### The tutorial shows how to parse invoice with OCR in VBScript and VB6

On this page you will learn from code samples for programming in VBScript and VB6.Writing of the code to parse invoice with OCR in VBScript and VB6 can be done by developers of any level using ByteScout Invoice Parser SDK. What is ByteScout Invoice Parser SDK? It is the automatic invoice parsing engine and data extraction SDK. Relies on the built-in database and supports thousands of vendors out of the box! Can work offline and can detects and extract company name, invoice number, date, total amount to be paid and other fields. The database of supported invoices is updated on regular basis. Data output can be exported in JSON, XML, CSV formats or directly integrated with other apps. It can help you to parse invoice with OCR in your VBScript and VB6 application.

The SDK samples like this one below explain how to quickly make your application do parse invoice with OCR in VBScript and VB6 with the help of ByteScout Invoice Parser SDK. Follow the instructions from the scratch to work and copy the VBScript and VB6 code. Test VBScript and VB6 sample code examples whether they respond your needs and requirements for the project.

Trial version of ByteScout Invoice Parser SDK can be downloaded for free from our website. It also includes source code samples for VBScript and VB6 and other programming languages.

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

##### ****ParseWithOCR.vbs:**
    
```
' This example demonstrates the use of Optical Character Recognition (OCR) to parse invoice data 
' from scanned PDF documents and raster images.

inputDocument = "..\..\DigitalOcean-scanned.jpg"

' Create InvoiceParser object
Set invoiceParser = CreateObject("Bytescout.InvoiceParser.InvoiceParser")
invoiceParser.RegistrationName = "demo"
invoiceParser.RegistrationKey = "demo"

' Enable Optical Character Recognition (OCR)
' in .Auto mode (SDK automatically checks if needs to use OCR or not)
invoiceParser.OCRMode = 1 ' OCRMode.Auto = 1

' Set the location of OCR language data files
invoiceParser.OCRLanguageDataFolder = "c:\Program Files\ByteScout Invoice Parser SDK\ocrdata"
			
' Set OCR language
' "eng" for english, "deu" for German, "fra" for French, etc. - according to files in "ocrdata" folder
invoiceParser.OCRLanguage = "eng"
' Find more language files at https://github.com/bytescout/ocrdata

' Parse invoice data in JSON format
invoiceParser.ParseDocument inputDocument, "output.json", 0 ' 0 = OutputFormat.JSON

WScript.Echo "Extracted text saved as 'output.json'."

Set invoiceParser = Nothing


```

<!-- code block end -->