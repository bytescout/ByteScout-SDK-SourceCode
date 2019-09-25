## How to get PDF page width and height in VBScript with ByteScout PDF To HTML SDK

### This code in VBScript shows how to get PDF page width and height with this how to tutorial

Sample source code below will show you how to cope with a difficult task like get PDF page width and height in VBScript. ByteScout PDF To HTML SDK is the SDK for PDF to HTML conversin. Generates static HTML version of input PDF and reconstructs all visual layout, text positions, vector and raster drawings, images, and form elements. Generated HTML requires no special software and can be viewed in any Internet browser. It can be used to get PDF page width and height using VBScript.

This rich sample source code in VBScript for ByteScout PDF To HTML SDK includes the number of functions and options you should do calling the API to get PDF page width and height. Follow the instructions from the scratch to work and copy the VBScript code. Implementing VBScript application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Download free trial version of ByteScout PDF To HTML SDK from our website with this and other source code samples for VBScript.

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

##### ****ReadPageWidthHeight.vbs:**
    
```
' Create Bytescout.PDF2HTML.HTMLExtractor object
Set extractor = CreateObject("Bytescout.PDF2HTML.HTMLExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Set HTML with CSS extraction mode
extractor.ExtractionMode = 1

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample2.pdf")

' read width and height of page #0 from PDF 
' and show default output width and calculated page height
MsgBox "Page #0" & vbCRLF & "Page height = " & CStr(extractor.GetPageHeight(0)) & vbCRLF & "Page width = " & CStr(extractor.GetPageWidth(0)) & vbCRLF & "Output width =" & CStr(extractor.OutputPageWidth) & vbCRLF & "Output Page Height = " & CStr(extractor.GetOutputHTMLPageHeight(0))

' uncomment to Convert pdf to HTML to file 
' extractor.SaveHtmlToFile_2 "output.html"

Set extractor = Nothing


```

<!-- code block end -->