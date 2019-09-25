## How to convert pdf to xfdf with pdf extractor sdk in VBScript using ByteScout Premium Suite

### Learn to code in VBScript to convert pdf to xfdf with pdf extractor sdk with this step-by-step tutorial

On this page you will learn from code samples for programming in VBScript.Writing of the code to convert pdf to xfdf with pdf extractor sdk in VBScript can be executed by programmers of any level using ByteScout Premium Suite. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording and you can use it to convert pdf to xfdf with pdf extractor sdk with VBScript.

This prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to convert pdf to xfdf with pdf extractor sdk.  Simply copy and paste in your VBScript project or application you and then run your app! Use of ByteScout Premium Suite in VBScript is also described in the documentation included along with the product.

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

##### ****PDFToXFDF.vbs:**
    
```
' Create Bytescout.PDFExtractor.XFDFExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XFDFExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"

extractor.SaveXFDFToFile "output.xml"

WScript.Echo "Extracted data saved to 'output.xml' file."

```

<!-- code block end -->