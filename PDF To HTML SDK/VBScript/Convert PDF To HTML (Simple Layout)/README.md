## How to convert PDF to HTML (simple layout) in VBScript and ByteScout PDF To HTML SDK

### The tutorial below will demonstrate how to convert PDF to HTML (simple layout) in VBScript

These source code samples are listed and grouped by their programming language and functions they use. Want to convert PDF to HTML (simple layout) in your VBScript app? ByteScout PDF To HTML SDK is designed for it. ByteScout PDF To HTML SDK is the PDF to HTML converter with visual layout, positions, vectors, images and form fields. Generated HTML can be viewed using browser without PDF reader.

This rich sample source code in VBScript for ByteScout PDF To HTML SDK includes the number of functions and options you should do calling the API to convert PDF to HTML (simple layout). In your VBScript project or application you may simply copy & paste the code and then run your app! Implementing VBScript application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

You can download free trial version of ByteScout PDF To HTML SDK from our website to see and try many others source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20To%20HTML%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20To%20HTML%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=kB2ELm_kCds](https://www.youtube.com/watch?v=kB2ELm_kCds)




<!-- code block begin -->

##### ****ExtractHTML.vbs:**
    
```
' Create Bytescout.PDF2HTML.HTMLExtractor object
Set extractor = CreateObject("Bytescout.PDF2HTML.HTMLExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Set plain HTML extraction mode
extractor.ExtractionMode = 0

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

' Set plain HTML extraction mode
extractor.ExtractionMode = 0

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