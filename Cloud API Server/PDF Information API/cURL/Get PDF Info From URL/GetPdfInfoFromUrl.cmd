@echo off

:: Path of the cURL executable
set CURL="curl.exe"

:: Direct URL of PDF file to get information
set SOURCE_FILE_URL=https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-info/sample.pdf


:: Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
:: If it's not then please replace this with with your hosting url.

:: Prepare URL for `PDF Info` API call
set QUERY="https://localhost/pdf/info?url=%SOURCE_FILE_URL%"

:: Perform request and save response to a file
%CURL% -# -X GET %QUERY% >response.json

:: Display the response
type response.json

:: Use any convenient way to parse JSON response and get information about PDF file


echo.
pause