## How to convert pdf to csv with pdf extractor sdk in VBScript using ByteScout Premium Suite

### Step-by-step tutorial on how to convert pdf to csv with pdf extractor sdk in VBScript

An easy to understand sample source code to learn how to convert pdf to csv with pdf extractor sdk in VBScript ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can convert pdf to csv with pdf extractor sdk in VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly convert pdf to csv with pdf extractor sdk in your VBScript application. Just copy and paste the code into your VBScript application’s code and follow the instructions. Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

ByteScout Premium Suite free trial version is available on our website. VBScript and other programming languages are supported.

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
extractor.LoadDocumentFromFile "../../sample3.pdf"

' You can change CSV separator and quotation symbols if needed
'extractor.CSVSeparatorSymbol = "," 
'extractor.CSVQuotaionSymbol = "'" 

extractor.SaveCSVToFile "output.csv"

WScript.Echo "Extracted data saved to 'output.csv' file."

```

<!-- code block end -->