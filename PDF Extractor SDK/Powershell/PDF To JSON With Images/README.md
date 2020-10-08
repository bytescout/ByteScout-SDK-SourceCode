## PDF to JSON with images in Powershell with ByteScout PDF Extractor SDK What is ByteScout PDF Extractor SDK? It is the SDK that helps developers to extract data from unstructured documents, pdf, images, scanned and electronic forms. Includes AI functions like automatic table detection, automatic table extraction and restructuring, text recognition and text restoration from pdf and scanned documents. Includes PDF to CSV, PDF to XML, PDF to JSON, PDF to searchable PDF functions as well as methods for low level data extraction.

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

##### **PDFToJSONWithImages.bat:**
    
```
@echo off

if "%~1"=="" (
	echo -----------------------------------------------------
	echo Invalid parameter!
	echo -----------------------------------------------------
	echo Usage: PDFToJSONWithImages.bat file_name
	echo Example: PDFToJSONWithImages.bat "sample1.pdf"
	echo -----------------------------------------------------
	if not "%NOPAUSE%"=="1" pause
	exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\PDFToJSONWithImages.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->    

<!-- code block begin -->

##### **PDFToJSONWithImages.ps1:**
    
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

# Create and activate Bytescout.PDFExtractor.JSONExtractor instance
$Extractor = New-Object Bytescout.PDFExtractor.JSONExtractor
$Extractor.RegistrationName = "demo"
$Extractor.RegistrationKey = "demo"
# Uncomment this line to get rid of empty nodes in JSON
# $Extractor.PreserveFormattingOnTextExtraction = $false
try {
    # Load sample PDF document
    $Extractor.LoadDocumentFromFile($InputFileName)

    # Set output image format
    # 0 = PNG; 1 = JPEG; 2 = GIF; 3 = BMP
    $Extractor.ImageFormat = 0

    # Save images to external files
    $Extractor.SaveImages = 1 # 1 = ImageHandling.OuterFile
    # Folder for external images
    $Extractor.ImageFolder = "images"
    $Extractor.SaveJSONToFile("result_with_external_images.json")

    # Embed images into JSON as Base64 encoded string
    # Save images to external files
    $Extractor.SaveImages = 2 # 2 = ImageHandling.Embed
    $Extractor.SaveJSONToFile("result_with_embedded_images.json")
} catch {

    Write-Host $_.Exception.Message
}

$Extractor.Dispose()
```

<!-- code block end -->