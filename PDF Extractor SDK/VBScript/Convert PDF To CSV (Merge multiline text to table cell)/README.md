## How to convert PDF to CSV (merge multiline text to table cell) in VBScript with ByteScout PDF Extractor SDK

### Write code in VBScript to convert PDF to CSV (merge multiline text to table cell) with this step-by-step tutorial

ByteScout tutorials are designed to explain the code for both VBScript beginners and advanced programmers. ByteScout PDF Extractor SDK can convert PDF to CSV (merge multiline text to table cell). It can be used from VBScript. ByteScout PDF Extractor SDK is the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities.

Fast application programming interfaces of ByteScout PDF Extractor SDK for VBScript plus the instruction and the code below will help you quickly learn how to convert PDF to CSV (merge multiline text to table cell). Just copy and paste the code into your VBScript application’s code and follow the instruction. Implementing VBScript application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

You can download free trial version of ByteScout PDF Extractor SDK from our website to see and try many others source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




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