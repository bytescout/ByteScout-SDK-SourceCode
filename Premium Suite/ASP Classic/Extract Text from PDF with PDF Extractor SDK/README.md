## How to extract text from PDF with PDF extractor SDK in ASP Classic and ByteScout Premium Suite

### This code in ASP Classic shows how to extract text from PDF with PDF extractor SDK with this how to tutorial

Sample source code below will display you how to manage a complex task like extract text from PDF with PDF extractor SDK in ASP Classic. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to extract text from PDF with PDF extractor SDK with ASP Classic.

The following code snippet for ByteScout Premium Suite works best when you need to quickly extract text from PDF with PDF extractor SDK in your ASP Classic application. Follow the instructions from scratch to work and copy the ASP Classic code. Enjoy writing a code with ready-to-use sample codes in ASP Classic.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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

##### ****ExtractText.asp:**
    
```
<%

' In case of "Server.CreateObject Failed", "Server object error "ASP 0177 : 8000ffff" or similar errors:
' Please try the following:
' - Open IIS 
' - Find application pools (DefaultAppPool is used by default)
' - Open its properties and check .NET CLR version selected:
' - if you have  .NET 1.1 then change to .NET CLR 2.00
' - if you have .NET CLR 2.00 then try to change to .NET CLR 4.0


Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample2.pdf")

' Save extracted text to file
outputText = extractor.GetText()

response.ContentType = "application/text"

' add content type header 
response.AddHeader "Content-Type", "application/text"

' set the content disposition
response.AddHeader "Content-Disposition", "inline;filename=HelloWorld.text"

' write the output text
response.Write OutputText
response.End


Set extractor = Nothing

%>

```

<!-- code block end -->