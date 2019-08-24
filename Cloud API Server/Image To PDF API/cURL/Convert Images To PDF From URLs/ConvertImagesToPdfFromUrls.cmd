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