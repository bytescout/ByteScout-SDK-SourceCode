@echo off

:: Path of the cURL executable
set CURL="curl.exe"

:: Direct URL of source file to search barcodes in.
set SOURCE_FILE_URL=https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf
:: Comma-separated list of barcode types to search. 
:: barcode types 
set BARCODE_TYPES=Code128,Code39,Interleaved2of5,EAN13
:: Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
set PAGES=

:: Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
:: If it's not then please replace this with with your hosting url.

:: Prepare URL for `Barcode Reader` API endpoint
set QUERY="https://localhost/barcode/read/from/url?types=%BARCODE_TYPES%&pages=%PAGES%&url=%SOURCE_FILE_URL%"

:: Perform request and save response to a file
%CURL% -# -X GET %QUERY% >response.json

:: Display the response
type response.json

:: Use any convenient way to parse JSON response and get information about decoded barcodes.


echo.
pause