## How to get pdf page width and height with pdf to html sdk in VBScript and ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to get pdf page width and height with pdf to html sdk in VBScript

On this page you will learn from code samples for programming in VBScript.Writing of the code to get pdf page width and height with pdf to html sdk in VBScript can be executed by programmers of any level using ByteScout Premium Suite. ByteScout Premium Suite: the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can get pdf page width and height with pdf to html sdk in VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly get pdf page width and height with pdf to html sdk in your VBScript application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! If you want to use these VBScript sample examples in one or many applications then they can be used easily.

You can download free trial version of ByteScout Premium Suite from our website with this and other source code samples for VBScript.

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