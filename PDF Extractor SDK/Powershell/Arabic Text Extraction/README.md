## arabic text extraction in Powershell using ByteScout PDF Extractor SDK ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker.

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

##### **ExtractArabicText.bat:**
    
```
@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: ExtractArabicText.bat file_name
	echo Example: ExtractArabicText.bat "sample_english_arabic.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ExtractArabicText.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->    

<!-- code block begin -->

##### **ExtractArabicText.ps1:**
    
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

    # Enable Arabic (and other RTL languages) text detection
    $Extractor.RTLTextAutoDetectionEnabled = $true


    # Construct output file name
    $OutputFileName = [System.IO.Path]::ChangeExtension($InputFileName, "txt")
    # Save extracted text to file
    $Extractor.SaveTextToFile($OutputFileName)
    Write-Host "Data has been extracted to $OutputFileName file."
} catch {

    Write-Host $_.Exception.Message
}

$Extractor.Dispose()
```

<!-- code block end -->