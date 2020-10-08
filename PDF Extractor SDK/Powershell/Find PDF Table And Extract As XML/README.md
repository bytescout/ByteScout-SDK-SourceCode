## How to find PDF table and extract as XML in Powershell and ByteScout PDF Extractor SDK ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker.

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

##### **FindTableAndExtractAsXml.bat:**
    
```
@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: FindTableAndExtractAsXml.bat file_name
	echo Example: FindTableAndExtractAsXml.bat "sample3.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\FindTableAndExtractAsXml.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->    

<!-- code block begin -->

##### **FindTableAndExtractAsXml.ps1:**
    
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

# Create and activate Bytescout.PDFExtractor.XMLExtractor instance
$Extractor = New-Object Bytescout.PDFExtractor.XMLExtractor
$Extractor.RegistrationName = "demo"
$Extractor.RegistrationKey = "demo"

# Create and activate Bytescout.PDFExtractor.TableDetector instance
$Detector = New-Object Bytescout.PDFExtractor.TableDetector
$Detector.RegistrationName = "demo"
$Detector.RegistrationKey = "demo"

# Set table detection mode to "bordered tables" - best for tables with closed solid borders.
# 0 = ColumnDetectionMode_ContentGroupsAndBorders
# 1 = ColumnDetectionMode_ContentGroups
# 2 = ColumnDetectionMode_Borders
# 3 = ColumnDetectionMode_BorderedTables
$Detector.ColumnDetectionMode = 3

# We should define what kind of tables we should detect.
# So we set min required number of columns to 3 ...
$Detector.DetectionMinNumberOfColumns = 3
# ... and we set min required number of rows to 3
$Detector.DetectionMinNumberOfRows = 3

try {
    # Load sample PDF document
    $Extractor.LoadDocumentFromFile($InputFileName)
    $Detector.LoadDocumentFromFile($InputFileName)

    # Get page count
    $PageCount = $Extractor.GetPageCount()
    Write-Host "Pages: $PageCount"

    # Iterate through pages
    for ($i = 0; $i -lt $PageCount; $i++) {

        $TableIndex = 1
        
        # Find first table and continue if found
        if ($Detector.FindTable($i) -eq $true) {

            do {
                # Set extraction area for CSV extractor to rectangle received from the table detector
                $Extractor.SetExtractionArea($Detector.FoundTableLocation)
                # export the table to CSV file
                $PageNo = $i + 1
                # Construct output file name
                $OutputFileName = "page-$PageNo-table-$TableIndex.csv"
                $Extractor.SavePageXMLToFile($i, $OutputFileName)
                $TableIndex++
            } while ($Detector.FindNextTable() -eq $true) # search next table
        }
    }
} catch {

    Write-Host $_.Exception.Message
}

# Cleanup
$Detector.Dispose()
$Extractor.Dispose()
```

<!-- code block end -->