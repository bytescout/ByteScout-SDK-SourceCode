## How to convert images to PDF from urls for image to PDF API in cURL and ByteScout Cloud API Server

### Step-by-step tutorial:How to convert images to PDF from urls to have image to PDF API in cURL

The documentation is written to assist you to apply all the necessary features on your side. ByteScout Cloud API Server was designed to assist image to PDF API in cURL. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

If you want to speed up the application’s code writing then cURL code samples for cURL developers help to implement using ByteScout Cloud API Server. This cURL sample code can be used by copying and pasting into your project. Once done,just compile your project and click Run. Use of ByteScout Cloud API Server in cURL is also described in the documentation given along with the product.

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

##### ****ConvertImagesToPdfFromUrls.cmd:**
    
```
@echo off

:: Path of the cURL executable
set CURL="curl.exe"

:: Direct URLs of image files to convert to PDF document
set SOURCE_IMAGE_URL1=https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image1.png
set SOURCE_IMAGE_URL2=https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image2.jpg
:: Result PDF file name
set RESULT_FILE_NAME=result.pdf

:: Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
:: If it's not then please replace this with with your hosting url.

:: Prepare URL for `Image To PDF` API call
set QUERY="https://localhost/pdf/convert/from/image?name=%RESULT_FILE_NAME%&url=%SOURCE_IMAGE_URL1%,%SOURCE_IMAGE_URL2%"

:: Perform request and save response to a file
%CURL% -# -X GET %QUERY% >response.json

:: Display the response
type response.json

:: Use any convenient way to parse JSON response and get URL of generated file(s)

echo.
pause
```

<!-- code block end -->