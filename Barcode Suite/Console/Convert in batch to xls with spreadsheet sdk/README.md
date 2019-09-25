## How to convert in batch to xls with spreadsheet sdk in Console with ByteScout Barcode Suite

### Step-by-step tutorial on how to convert in batch to xls with spreadsheet sdk in Console

The code displayed below will guide you to install an Console app to convert in batch to xls with spreadsheet sdk. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can convert in batch to xls with spreadsheet sdk in Console.

Want to save time? You will save a lot of time on writing and testing code as you may just take the Console code from ByteScout Barcode Suite for convert in batch to xls with spreadsheet sdk below and use it in your application. IF you want to implement the functionality, just copy and paste this code for Console below into your code editor with your app, compile and run your application. Complete and detailed tutorials and documentation are available along with installed ByteScout Barcode Suite if you'd like to learn more about the topic and the details of the API.

Our website gives trial version of ByteScout Barcode Suite for free. It also includes documentation and source code samples.

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
set current_dir=%CD%

@echo off

rem  This command will convert all files from "Input Files" directory to XLS format.
rem  Converter will use ";" delimiter when reading CSV and TXT files.

"%PROGRAMFILES%\Bytescout Spreadsheet SDK\Console\Bytescout.Spreadsheet.Console.exe" ".\Input Files\*.*" /F XLS /O ".\Output Files" /D ";"

pause
```

<!-- code block end -->