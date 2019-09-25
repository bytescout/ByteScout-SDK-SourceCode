## How to extract table structure from pdf with pdf extractor sdk in VBScript with ByteScout Premium Suite

### Learn to code in VBScript to extract table structure from pdf with pdf extractor sdk with this step-by-step tutorial

These source code samples are assembled by their programming language and functions they apply. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can extract table structure from pdf with pdf extractor sdk in VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly extract table structure from pdf with pdf extractor sdk in your VBScript application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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