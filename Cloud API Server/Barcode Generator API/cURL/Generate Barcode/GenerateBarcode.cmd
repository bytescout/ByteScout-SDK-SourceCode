# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

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