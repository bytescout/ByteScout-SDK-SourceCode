## How to generate barcode for barcode generator API in cURL and ByteScout Cloud API Server

### Learn in simple ways: How to generate barcode for barcode generator API in cURL

These simple tutorials explain the code material for beginners and advanced programmers who are using cURL. Barcode generator API in cURL can be applied with ByteScout Cloud API Server. ByteScout Cloud API Server is the ready to deploy Web API Server that can be deployed in less than thirty minutes into your own in-house Windows server (no Internet connnection is required to process data!) or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using built-in ByteScout powered engine, no cloud services are used to process your data!.

CURL code snippet like this for ByteScout Cloud API Server works best when you need to quickly implement barcode generator API in your cURL application. Follow the tutorial and copy - paste code for cURL into your project's code editor. Use of ByteScout Cloud API Server in cURL is also described in the documentation given along with the product.

Free! Free! Free! ByteScout free trial version is available for FREE download from our website. Programming tutorials along with source code samples are assembled.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Cloud%20API%20Server%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Cloud%20API%20Server%20Question) 

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

##### ****GenerateBarcode.cmd:**
    
```
@echo off

:: Path of the cURL executable
set CURL="curl.exe"

:: Barcode type.
set BARCODE_TYPE=Code128
:: Barcode value
set BARCODE_VALUE=qweasd123456
:: Result image file name
set RESULT_FILE_NAME=barcode.png

:: Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
:: If it's not then please replace this with with your hosting url.

:: Prepare URL for `Barcode Generator` API endpoint
set QUERY="https://localhost/barcode/generate?name=%RESULT_FILE_NAME%&type=%BARCODE_TYPE%&value=%BARCODE_VALUE%"

:: Perform request and save response to a file
%CURL% -# -X GET %QUERY% >response.json

:: Display the response
type response.json

:: Use any convenient way to parse JSON response and get URL of generated file(s)

echo.
pause
```

<!-- code block end -->