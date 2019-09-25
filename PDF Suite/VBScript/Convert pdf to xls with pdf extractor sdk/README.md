## How to convert pdf to xls with pdf extractor sdk in VBScript with ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to convert pdf to xls with pdf extractor sdk in VBScript

The coding instructions are formulated to help you to try-out the features without the requirement to write your own code. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript and you can use it to convert pdf to xls with pdf extractor sdk with VBScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout PDF Suite for convert pdf to xls with pdf extractor sdk below and use it in your application.  Simply copy and paste in your VBScript project or application you and then run your app! Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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