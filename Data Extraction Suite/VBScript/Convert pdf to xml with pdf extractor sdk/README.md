## How to convert pdf to xml with pdf extractor sdk in VBScript with ByteScout Data Extraction Suite

### This code in VBScript shows how to convert pdf to xml with pdf extractor sdk with this how to tutorial

These sample source codes on this page below are displaying how to convert pdf to xml with pdf extractor sdk in VBScript. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can be applied to convert pdf to xml with pdf extractor sdk using VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Data Extraction Suite for VBScript plus the guidelines and the code below will help you quickly learn how to convert pdf to xml with pdf extractor sdk. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout Data Extraction Suite in VBScript is also described in the documentation included along with the product.

Trial version of ByteScout Data Extraction Suite is available for free. Source code samples are included to help you with your VBScript app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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

##### ****PdfToXml.vbs:**
    
```
' Create Bytescout.PDFExtractor.XMLExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XMLExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"

extractor.SaveXMLToFile "output.xml"

WScript.Echo "Extracted data saved to 'output.xml' file."
```

<!-- code block end -->