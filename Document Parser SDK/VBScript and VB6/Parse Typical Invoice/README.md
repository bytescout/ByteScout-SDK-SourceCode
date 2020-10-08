## How to parse typical invoice in VBScript and VB6 and ByteScout Document Parser SDK ByteScout Document Parser SDK: the template based data extraction engine can process thousands and millions of documents per day based on templates. Can work online and offline for privacy focused tasks. Templates can be supported and updated without any programming or technical knowledge required. Output is generated in JSON, CSV, XML and custom format if required.

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

##### **ParseTypicalInvoice.vbs:**
    
```
' This example demonstrates parsing of typical invoice.

inputDocument = ".\SampleInvoice.pdf"


' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Add an internal generic template for typical invoices.
' Note, if it does not parse all required fields, you should create
' own template using Template Editor application.
documentParser.AddTemplate("internal://invoice")

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "output.json", 0, False ' 0 = OutputFormat.JSON

' Parse document data in YAML format
documentParser.ParseDocument inputDocument, "output.yml", 1, False ' 1 = OutputFormat.YAML

' Parse document data in XML format
documentParser.ParseDocument inputDocument, "output.xml", 2, True ' 2 = OutputFormat.XML

' Parse document data in CSV format
documentParser.ParseDocument inputDocument, "output.csv", 3, True ' 3 = OutputFormat.CSV

WScript.Echo "Parsed data saved as 'output.json', 'output.yml', 'output.xml', 'output.csv'."

Set documentParser = Nothing


```

<!-- code block end -->