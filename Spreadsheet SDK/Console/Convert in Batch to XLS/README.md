## How to convert in batch to XLS in Console with ByteScout Spreadsheet SDK

### The tutorial shows how to convert in batch to XLS in Console

The sample source code below will teach you how to convert in batch to XLS in Console. ByteScout Spreadsheet SDK is the library (SDK) that is capable of writing, reading, modifying and calculating Excel and CSV spreadsheets. Most popular formulas can be calculated and reculculated with Excel installed. You may import or export data to and from CSV, XML, JSON as well as to and from databases, arrays. It can convert in batch to XLS in Console.

Console code samples for Console developers help to speed up coding of your application when using ByteScout Spreadsheet SDK. Just copy and paste the code into your Console application’s code and follow the instruction. Code testing will allow the function to be tested and work properly with your data.

ByteScout Spreadsheet SDK free trial version is available on our website. Console and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Spreadsheet%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Spreadsheet%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=nm_7I0PN1TY](https://www.youtube.com/watch?v=nm_7I0PN1TY)




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