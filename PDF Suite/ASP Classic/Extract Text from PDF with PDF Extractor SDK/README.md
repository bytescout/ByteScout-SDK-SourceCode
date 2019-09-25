## How to extract text from PDF with PDF extractor SDK in ASP Classic and ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to extract text from PDF with PDF extractor SDK in ASP Classic

Quickly learn how to extract text from PDF with PDF extractor SDK in ASP Classic with this sample source code. Want to extract text from PDF with PDF extractor SDK in your ASP Classic app? ByteScout PDF Suite is designed for it. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Want to quickly learn? This fast application programming interfaces of ByteScout PDF Suite for ASP Classic plus the guidelines and the code below will help you quickly learn how to extract text from PDF with PDF extractor SDK.  Simply copy and paste in your ASP Classic project or application you and then run your app! Check ASP Classic sample code samples to see if they respond to your needs and requirements for the project.

ByteScout provides the free trial version of ByteScout PDF Suite along with the documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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