## How to find invoice total amount in PDF with regex in Powershell with ByteScout PDF Extractor SDK ByteScout PDF Extractor SDK: the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




<!-- code block begin -->

##### **FindInvoiceTotalNumberWithRegexp.bat:**
    
```
@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: FindInvoiceTotalNumberWithRegexp.bat file_name
	echo Example: FindInvoiceTotalNumberWithRegexp.bat "SampleInvoice.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\FindInvoiceTotalNumberWithRegexp.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->    

<!-- code block begin -->

##### **FindInvoiceTotalNumberWithRegexp.ps1:**
    
```
#*******************************************************************************************#
#                                                                                           #
# Download Free Evaluation Version From: https://bytescout.com/download/web-installer       #
#                                                                                           #
# Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               #
#                                                                                           #
# Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                #
# https://www.bytescout.com                                                                 #
# https://pdf.co                                                                            #
#                                                                                           #
#*******************************************************************************************#

# Note: if you are looking for a more higher level API to extract data from invoices, reports, statements
# then please check Document Parser SDK and Web API at https://bytescout.com/products/developer/documentparsersdk/index.html
# and https://pdf.co for secure and scalable web api

Param (
    [Parameter(Mandatory = $true)]
    [string] $InputFileName = ""
)

#Add reference to Bytescout.PDFExtractor.dll assembly
Add-Type -Path "C:\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll"

# Check input file exists
if ((Test-Path $InputFileName) -eq $false) {

    Write-Host "Input file does not exist." -ForegroundColor Red
    Exit 0
}

# Create and activate Bytescout.PDFExtractor.TextExtractor instance
$Extractor = New-Object Bytescout.PDFExtractor.TextExtractor
$Extractor.RegistrationName = "demo"
$Extractor.RegistrationKey = "demo"

try {
    # Load sample PDF document
    $Extractor.LoadDocumentFromFile($InputFileName)

    # Get page count
    $PageCount = $Extractor.GetPageCount()
    Write-Host "Pages: $PageCount"

    # Enable the regular expressions
    $Extractor.RegexSearch = $true
    
    # Search email Addresses
    $RegexPattern = "(TOTAL: )[$]\d+"
    # See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx

    # Iterate through pages
    for ($i = 0; $i -lt $PageCount; $i++) {

        
        # Search each page for the pattern
        if ($Extractor.Find($i, $RegexPattern, $false) -eq $true) {

            do {
        
                $PageNo = $i + 1
                Write-Host "Found on page $PageNo"
                # Iterate through each element in the found text
                foreach ($Element in $Extractor.FoundText.Elements) {
                
                    Write-Host "Total Amount Number: " $Element.Text.Replace("TOTAL:", "").Trim()
                }
            } while ($Extractor.FindNext() -eq $true)
        } else {

            Write-Host "Nothing found"
        }
    }
} catch {

    Write-Host $_.Exception.Message
}

$Extractor.Dispose()
```

<!-- code block end -->