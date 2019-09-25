## How to extract text from PDF in ASP Classic and ByteScout PDF Extractor SDK

### Tutorial on how to extract text from PDF in ASP Classic

The sample source codes on this page shows how to extract text from PDF in ASP Classic. ByteScout PDF Extractor SDK can extract text from PDF. It can be used from ASP Classic. ByteScout PDF Extractor SDK is the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities.

Fast application programming interfaces of ByteScout PDF Extractor SDK for ASP Classic plus the instruction and the code below will help you quickly learn how to extract text from PDF. In your ASP Classic project or application you may simply copy & paste the code and then run your app! Enjoy writing a code with ready-to-use sample codes in ASP Classic.

Free trial version of ByteScout PDF Extractor SDK is available for download from our website. Get it to try other source code samples for ASP Classic.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




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