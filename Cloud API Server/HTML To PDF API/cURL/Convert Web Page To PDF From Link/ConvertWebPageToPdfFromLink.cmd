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