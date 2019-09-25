## How to extract table structure from pdf with pdf extractor sdk in VBScript with ByteScout Data Extraction Suite

### If you want to learn more then this tutorial will show how to extract table structure from pdf with pdf extractor sdk in VBScript

This sample source code below will display you how to extract table structure from pdf with pdf extractor sdk in VBScript. Want to extract table structure from pdf with pdf extractor sdk in your VBScript app? ByteScout Data Extraction Suite is designed for it. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

The following code snippet for ByteScout Data Extraction Suite works best when you need to quickly extract table structure from pdf with pdf extractor sdk in your VBScript application. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

ByteScout Data Extraction Suite free trial version is available on our website. VBScript and other programming languages are supported.

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

##### ****ExtractTabledStructure.vbs:**
    
```
' Create Bytescout.PDFExtractor.StructuredExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.StructuredExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"
           
For ipage = 0 To extractor.GetPageCount() - 1 

    ' starting extraction from page #"
    extractor.PrepareStructure ipage

    rowCount = extractor.GetRowCount(ipage)
    
    For row = 0 To rowCount - 1 
        columnCount = extractor.GetColumnCount(ipage, row)

        For col = 0 To columnCount-1
            WScript.Echo "Cell at page #" +CStr(ipage) + ", row=" & CStr(row) & ", column=" & _
                CStr(col) & vbCRLF & extractor.GetCellValue(ipage, row, col)
        Next
    Next
Next


```

<!-- code block end -->