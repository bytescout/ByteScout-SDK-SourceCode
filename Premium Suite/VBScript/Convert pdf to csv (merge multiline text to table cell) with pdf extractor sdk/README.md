## How to convert pdf to csv (merge multiline text to table cell) with pdf extractor sdk in VBScript using ByteScout Premium Suite

### Learn to code in VBScript to convert pdf to csv (merge multiline text to table cell) with pdf extractor sdk with this step-by-step tutorial

The sample source codes on this page shows how to convert pdf to csv (merge multiline text to table cell) with pdf extractor sdk in VBScript. What is ByteScout Premium Suite? It is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to convert pdf to csv (merge multiline text to table cell) with pdf extractor sdk in your VBScript application.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guidelines and the code below will help you quickly learn how to convert pdf to csv (merge multiline text to table cell) with pdf extractor sdk. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Further improvement of the code will make it more robust.

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

##### ****PdfToCsv.vbs:**
    
```
' Create Bytescout.PDFExtractor.CSVExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.CSVExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3_multiline.pdf"

' You can change CSV separator and quotation symbols if needed
'extractor.CSVSeparatorSymbol = "," 
'extractor.CSVQuotaionSymbol = "'" 

' For multiline cell join extracted cell text into single line
extractor.LineGroupingMode = 1 'LineGroupingMode.GroupByRows
extractor.Unwrap = True

extractor.SaveCSVToFile "output.csv"

WScript.Echo "Extracted data saved to 'output.csv' file."

```

<!-- code block end -->