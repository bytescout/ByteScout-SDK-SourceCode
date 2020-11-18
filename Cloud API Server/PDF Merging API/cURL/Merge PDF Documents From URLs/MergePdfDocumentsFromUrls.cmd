# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

@echo off

:: Path of the cURL executable
set CURL="curl.exe"

:: Direct URLs of PDF documents to merge
set SOURCE_FILE_URL1=https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-merge/sample1.pdf
set SOURCE_FILE_URL2=https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-merge/sample2.pdf
:: Result PDF file name
set RESULT_FILE_NAME=result.pdf

:: Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
:: If it's not then please replace this with with your hosting url.

:: Prepare URL for `Merge PDF` API call
set QUERY="https://localhost/pdf/merge?name=%RESULT_FILE_NAME%&url=%SOURCE_FILE_URL1%,%SOURCE_FILE_URL2%"

:: Perform request and save response to a file
%CURL% -# -X GET %QUERY% >response.json

:: Display the response
type response.json

:: Use any convenient way to parse JSON response and get URL of generated file(s)


echo.
pause