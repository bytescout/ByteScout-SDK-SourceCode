:: (!) If you are getting '(403) Forbidden' error please ensure you have set the correct API_KEY

@echo off

:: Path of the cURL executable
set CURL="curl.exe"

:: The authentication key (API Key).
:: Get your own by registering at https://secure.bytescout.com/users/sign_up
set API_KEY=***********************************

:: URL of web page to convert to PDF document.
set SOURCE_URL=http://www.usa.gov
:: Result PDF file name
set RESULT_FILE_NAME=result.pdf


:: Prepare URL for `Web Page to PDF` API call
set QUERY="https://bytescout.io/v1/pdf/convert/from/url?name=%RESULT_FILE_NAME%&url=%SOURCE_URL%"

:: Perform request and save response to a file
%CURL% -# -X GET -H "x-api-key: %API_KEY%" %QUERY% >response.json

:: Display the response
type response.json

:: Use any convenient way to parse JSON response and get URL of generated file(s)


echo.
pause