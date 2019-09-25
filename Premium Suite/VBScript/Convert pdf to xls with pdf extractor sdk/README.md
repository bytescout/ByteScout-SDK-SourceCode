## How to convert pdf to xls with pdf extractor sdk in VBScript and ByteScout Premium Suite

### This code in VBScript shows how to convert pdf to xls with pdf extractor sdk with this how to tutorial

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to convert pdf to xls with pdf extractor sdk using VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly convert pdf to xls with pdf extractor sdk in your VBScript application. Just copy and paste the code into your VBScript application’s code and follow the instructions. If you want to use these VBScript sample examples in one or many applications then they can be used easily.

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