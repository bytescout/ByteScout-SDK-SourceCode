## How to extract text from pdf with pdf extractor sdk in VBScript and ByteScout Premium Suite

### How to write a robust code in VBScript to extract text from pdf with pdf extractor sdk with this step-by-step tutorial

These sample source codes on this page below are displaying how to extract text from pdf with pdf extractor sdk in VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to extract text from pdf with pdf extractor sdk using VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Premium Suite for extract text from pdf with pdf extractor sdk below and use it in your application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

Trial version of ByteScout Premium Suite is available for free. Source code samples are included to help you with your VBScript app.

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

##### ****ExtractAllText.vbs:**
    
```
' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

' Save extracted text to file
extractor.SaveTextToFile("result.txt")

' Open the output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "result.txt", 1, false
Set shell = Nothing

Set extractor = Nothing


```

<!-- code block end -->