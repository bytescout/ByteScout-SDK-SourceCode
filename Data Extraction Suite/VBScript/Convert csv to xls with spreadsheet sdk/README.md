## How to convert csv to xls with spreadsheet sdk in VBScript with ByteScout Data Extraction Suite

### Step-by-step tutorial on how to convert csv to xls with spreadsheet sdk in VBScript

Quickly learn how to convert csv to xls with spreadsheet sdk in VBScript with this sample source code. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK and you can use it to convert csv to xls with spreadsheet sdk with VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Data Extraction Suite. Just copy and paste the code into your VBScript application’s code and follow the instructions. This basic programming language sample code for VBScript will do the whole work for you to convert csv to xls with spreadsheet sdk.

Our website gives trial version of ByteScout Data Extraction Suite for free. It also includes documentation and source code samples.

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

##### ****CSVToXLS.vbs:**
    
```
Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

document.LoadFromFile("input.csv")

' save document
document.SaveAs "Output.xls"

' save as xlsx
document.SaveAs "Output.xlsx"

' close Spreadsheet
Set document = Nothing

MsgBox "Done! See output.xls"


```

<!-- code block end -->