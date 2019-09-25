## How to convert pdf to html (complex layout) with pdf to html sdk in VBScript with ByteScout PDF Suite

### Learn to code in VBScript to convert pdf to html (complex layout) with pdf to html sdk with this step-by-step tutorial

The code displayed below will guide you to install an VBScript app to convert pdf to html (complex layout) with pdf to html sdk. ByteScout PDF Suite: the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can convert pdf to html (complex layout) with pdf to html sdk in VBScript.

The SDK samples given below describe how to quickly make your application do convert pdf to html (complex layout) with pdf to html sdk in VBScript with the help of ByteScout PDF Suite. Just copy and paste the code into your VBScript application’s code and follow the instructions. Complete and detailed tutorials and documentation are available along with installed ByteScout PDF Suite if you'd like to learn more about the topic and the details of the API.

Trial version of ByteScout PDF Suite is available for free. Source code samples are included to help you with your VBScript app.

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

##### ****ExtractHTML.vbs:**
    
```
' Create Bytescout.PDF2HTML.HTMLExtractor object
Set extractor = CreateObject("Bytescout.PDF2HTML.HTMLExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Set HTML with CSS extraction mode
extractor.ExtractionMode = 1

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample2.pdf")

' Save extracted HTML to file
extractor.SaveHtmlToFile_2 "output.html" 

' Open output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "output.html", 1, false
Set shell = Nothing

Set extractor = Nothing


```

<!-- code block end -->    

<!-- code block begin -->

##### ****ExtractHTMLFromPage.vbs:**
    
```
' Create Bytescout.PDF2HTML.HTMLExtractor object
Set extractor = CreateObject("Bytescout.PDF2HTML.HTMLExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Set HTML with CSS extraction mode
extractor.ExtractionMode = 1

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample2.pdf")

' Convert 2-nd page to HTML and save it to file
extractor.SaveHtmlPageToFile 1, "output.html"

' Open output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "output.html", 1, false
Set shell = Nothing

Set extractor = Nothing


```

<!-- code block end -->