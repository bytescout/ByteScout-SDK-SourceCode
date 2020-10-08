## How to split PDF document in Powershell with ByteScout PDF Extractor SDK ByteScout PDF Extractor SDK is the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities.

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

##### **SplittingExample.bat:**
    
```
@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: SplittingExample.bat file_name
	echo Example: SplittingExample.bat "sample.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\SplittingExample.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->    

<!-- code block begin -->

##### **SplittingExample.ps1:**
    
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

# This example demonstrates various PDF document splitting scenarios:
# - extract a single page;
# - split in two parts;
# - split by ranges specified in text form: "1-5,6,7-10,11-".

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

# Create and activate Bytescout.PDFExtractor.DocumentSplitter instance
$Splitter = New-Object Bytescout.PDFExtractor.DocumentSplitter
$Splitter.RegistrationName = "demo"
$Splitter.RegistrationKey = "demo"
$Splitter.OptimizeSplittedDocuments = $true

try {

    # Extracting specific page
    $Splitter.ExtractPage($InputFileName, "page3.pdf", 3) # (!) Note: page number is 1-based.
    Write-Host "Extracted page 3 to file ""page3.pdf"""

    # Split in two parts
    $Splitter.Split($InputFileName, "part1.pdf", "part2.pdf", 3) # (!) Note: page number is 1-based.
    Write-Host "Splitted at page 3 to files ""part1.pdf"" and ""part2.pdf"""

    # Split by ranges
    $Files = $Splitter.Split($InputFileName, "1-3,4-6,7,8-") # (!) Note: page numbers are 1-based; ending "-" means "to the end"
    Write-Host "Splitted by ranges:"
    foreach ($OutputFileName in $Files) {

        Write-Host $OutputFileName
    }
} catch {

    Write-Host $_.Exception.Message
}

$Splitter.Dispose()
```

<!-- code block end -->