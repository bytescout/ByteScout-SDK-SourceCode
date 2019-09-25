## How to change PDF to HTML output page width in VBScript and ByteScout PDF To HTML SDK

### The tutorial below will demonstrate how to change PDF to HTML output page width in VBScript

The sample source codes on this page shows how to change PDF to HTML output page width in VBScript. ByteScout PDF To HTML SDK can change PDF to HTML output page width. It can be used from VBScript. ByteScout PDF To HTML SDK is the SDK for PDF to HTML conversin. Generates static HTML version of input PDF and reconstructs all visual layout, text positions, vector and raster drawings, images, and form elements. Generated HTML requires no special software and can be viewed in any Internet browser.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF To HTML SDK for change PDF to HTML output page width below and use it in your application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Further enhancement of the code will make it more vigorous.

Our website provides trial version of ByteScout PDF To HTML SDK for free. It also includes documentation and source code samples.

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

' Set HTML with CSS extraction mode
extractor.ExtractionMode = 1

' set output width to 200 pixels
extractor.OutputPageWidth = 200


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