## How to convert web page to PDF from link for HTML to PDF API in cURL using ByteScout Cloud API Server

### How to convert web page to PDF from link in cURL with easy ByteScout code samples to make HTML to PDF API. Step-by-step tutorial

These simple tutorials explain the code material for beginners and advanced programmers who are using cURL. ByteScout Cloud API Server was designed to assist HTML to PDF API in cURL. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

If you want to speed up the application’s code writing then cURL code samples for cURL developers help to implement using ByteScout Cloud API Server. Open your cURL project and simply copy & paste the code and then run your app! Check cURL sample code examples to see if they respond to your needs and requirements for the project.

ByteScout Cloud API Server - free trial version is available on our website. Also, there are other code samples to help you with your cURL application included into trial version.

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

##### ****ConvertWebPageToPdfFromLink.cmd:**
    
```
@echo off

:: Path of the cURL executable
set CURL="curl.exe"

:: URL of web page to convert to PDF document.
set SOURCE_URL=http://www.usa.gov
:: Result PDF file name
set RESULT_FILE_NAME=result.pdf


:: Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
:: If it's not then please replace this with with your hosting url.

:: Prepare URL for `Web Page to PDF` API call
set QUERY="https://localhost/pdf/convert/from/url?name=%RESULT_FILE_NAME%&url=%SOURCE_URL%"

:: Perform request and save response to a file
%CURL% -# -X GET %QUERY% >response.json

:: Display the response
type response.json

:: Use any convenient way to parse JSON response and get URL of generated file(s)


echo.
pause
```

<!-- code block end -->