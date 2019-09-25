## How to convert pdf to json with pdf extractor sdk in VBScript using ByteScout Data Extraction Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to convert pdf to json with pdf extractor sdk in VBScript

Sample source code below will display you how to manage a complex task like convert pdf to json with pdf extractor sdk in VBScript. What is ByteScout Data Extraction Suite? It is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can help you to convert pdf to json with pdf extractor sdk in your VBScript application.

This prolific sample source code in VBScript for ByteScout Data Extraction Suite contains various functions and other necessary options you should do calling the API to convert pdf to json with pdf extractor sdk.  Simply copy and paste in your VBScript project or application you and then run your app! Complete and detailed tutorials and documentation are available along with installed ByteScout Data Extraction Suite if you'd like to learn more about the topic and the details of the API.

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

##### ****PdfToJson.vbs:**
    
```
' Create Bytescout.PDFExtractor.JSONExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.JSONExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"

extractor.SaveJSONToFile "output.json"

WScript.Echo "Extracted data saved to 'output.json' file."

```

<!-- code block end -->