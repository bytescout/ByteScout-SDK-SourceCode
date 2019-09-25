## How to convert in batch from xls to csv with spreadsheet sdk in Console with ByteScout Barcode Suite

### Learn to convert in batch from xls to csv with spreadsheet sdk in Console

The documentation is designed for a specific purpose to help you to apply the features on your side. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can convert in batch from xls to csv with spreadsheet sdk in Console.

The following code snippet for ByteScout Barcode Suite works best when you need to quickly convert in batch from xls to csv with spreadsheet sdk in your Console application. IF you want to implement the functionality, just copy and paste this code for Console below into your code editor with your app, compile and run your application. If you want to use these Console sample examples in one or many applications then they can be used easily.

ByteScout Barcode Suite free trial version is available on our website. Console and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

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

##### ****ConvertToXLS.bat:**
    
```
@echo off

rem This command will convert XLS file to CSV with TAB delimiter.

"%PROGRAMFILES%\Bytescout Spreadsheet SDK\Console\Bytescout.Spreadsheet.Console.exe" ".\Input Files\sample.xls" /F CSV /O ".\Output Files" /D "\t"

pause
```

<!-- code block end -->