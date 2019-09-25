## How to convert in batch from XLS to CSV in Console and ByteScout Spreadsheet SDK

### Write code in Console to convert in batch from XLS to CSV with this step-by-step tutorial

The documentation is designed to help you to implement the features on your side. What is ByteScout Spreadsheet SDK? It is the SDK that can write and read, modify and calculate Excel and CSV spreadsheets. Most popular formulas are supported. You may import or export data to and from CSV, XML, JSON as well as to and from databases, arrays. It can help you to convert in batch from XLS to CSV in your Console application.

Fast application programming interfaces of ByteScout Spreadsheet SDK for Console plus the instruction and the code below will help you quickly learn how to convert in batch from XLS to CSV. Just copy and paste the code into your Console application’s code and follow the instruction. Code testing will allow the function to be tested and work properly with your data.

Download free trial version of ByteScout Spreadsheet SDK from our website with this and other source code samples for Console.

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
@echo off

rem This command will convert XLS file to CSV with TAB delimiter.

"%PROGRAMFILES%\Bytescout Spreadsheet SDK\Console\Bytescout.Spreadsheet.Console.exe" ".\Input Files\sample.xls" /F CSV /O ".\Output Files" /D "\t"

pause
```

<!-- code block end -->