:: (!) If you are getting '(403) Forbidden' error please ensure you have set the correct API_KEY

@echo off

:: Path of the cURL executable
set CURL="curl.exe"

:: The authentication key (API Key).
:: Get your own by registering at https://secure.bytescout.com/users/sign_up
set API_KEY=***********************************

:: Barcode type. See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeGenerateGet
set BARCODE_TYPE=Code128
:: Barcode value
set BARCODE_VALUE=qweasd123456
:: Result image file name
set RESULT_FILE_NAME=barcode.png

:: Prepare URL for `Barcode Generator` API endpoint
set QUERY="https://bytescout.io/v1/barcode/generate?name=%RESULT_FILE_NAME%&type=%BARCODE_TYPE%&value=%BARCODE_VALUE%"

:: Perform request and save response to a file
%CURL% -# -X GET -H "x-api-key: %API_KEY%" %QUERY% >response.json

:: Display the response
type response.json


:: Use any convenient way to parse JSON response and get URL of generated file(s)

echo.
pause