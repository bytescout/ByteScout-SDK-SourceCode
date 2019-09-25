## How to convert PDF to XLS in VBScript with ByteScout PDF Extractor SDK

### How to code in VBScript to convert PDF to XLS with this step-by-step tutorial

With this source code sample you may quickly learn how to convert PDF to XLS in VBScript. ByteScout PDF Extractor SDK is the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities and you can use it to convert PDF to XLS with VBScript.

VBScript code samples for VBScript developers help to speed up coding of your application when using ByteScout PDF Extractor SDK. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Test VBScript sample code examples whether they respond your needs and requirements for the project.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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

##### ****PdfToXls-CommandLine.vbs:**
    
```
if Wscript.Arguments.Length < 2 Then
    WScript.Echo "Usage: PdfToXls.vbs ""input.pdf"" ""output.xlsx"""
    WScript.Quit
End If

' Create Bytescout.PDFExtractor.XLSExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XLSExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Set Excel format
extractor.OutputFormat = 1 ' 0 - XLS format; 1 - XLSX format.

' Uncomment this line if you need all pages converted into a single worksheet:
'extractor.PageToWorksheet = False

' Load sample PDF document
extractor.LoadDocumentFromFile WScript.Arguments.Item(0)

' Extract data to Excel format
extractor.SaveToXLSFile WScript.Arguments.Item(1)

WScript.Echo "Extracted data saved to '" & WScript.Arguments.Item(1) & "' file."

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PdfToXls.bat:**
    
```
REM Run the script from the command line
cscript.exe PdfToXls-CommandLine.vbs "../../sample3.pdf" "output.xlsx"
pause



```

<!-- code block end -->