## How to convert PDF to JSON with PDF extractor SDK in Powershell with ByteScout Data Extraction Suite

### How to write a robust code in Powershell to convert PDF to JSON with PDF extractor SDK with this step-by-step tutorial

These sample source codes on this page below are displaying how to convert PDF to JSON with PDF extractor SDK in Powershell. ByteScout Data Extraction Suite can convert PDF to JSON with PDF extractor SDK. It can be applied from Powershell. ByteScout Data Extraction Suite is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

Want to save time? You will save a lot of time on writing and testing code as you may just take the Powershell code from ByteScout Data Extraction Suite for convert PDF to JSON with PDF extractor SDK below and use it in your application. IF you want to implement the functionality, just copy and paste this code for Powershell below into your code editor with your app, compile and run your application. If you want to use these Powershell sample examples in one or many applications then they can be used easily.

Trial version of ByteScout Data Extraction Suite is available for free. Source code samples are included to help you with your Powershell app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****pdf-to-json.bat:**
    
```
@echo off

if "%~1"=="" (
    echo -----------------------------------------------------
    echo Invalid parameter!
    echo -----------------------------------------------------
    echo Usage: pdf-to-json.bat folder_path
    echo Example: pdf-to-json.bat "c:\documents"
    echo -----------------------------------------------------
    if not "%NOPAUSE%"=="1" pause
    exit /b 1
)

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\pdf-to-json.ps1" "%1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->    

<!-- code block begin -->

##### ****pdf-to-json.ps1:**
    
```
Param(
    [Parameter(Mandatory = $true)]
    [string] $InputFolder = ""
)

# Add reference to Bytescout.PDFExtractor.dll assembly
Add-Type -Path "c:\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll"

# Check input folder exists
if ((Test-Path $InputFolder) -eq $false) {
    Write-Host "Target folder does not exist." -ForegroundColor Red
    exit 0
}

# Create and activate JSONExtractor instance
$jsonExtractor = New-Object Bytescout.PDFExtractor.JSONExtractor
$jsonExtractor.RegistrationName = "demo"
$jsonExtractor.RegistrationKey = "demo"

try {
    # Get PDF files from input folder
    $files = Get-ChildItem -Path $InputFolder -Recurse -Include "*.pdf"
    foreach ($file in $files) {
        Write-Host "Input file" $file.FullName
        # Construct output file name
        $jsonFileName = [System.IO.Path]::ChangeExtension($file.FullName, "json")
        Write-Host "  Output file" $jsonFileName
        # Load PDF document
        $jsonExtractor.LoadDocumentFromFile($file.FullName)
        # Disable the formatting reconstruction
        $jsonExtractor.PreserveFormattingOnTextExtraction = $false
        # Extract first page to JSON
        $jsonExtractor.SaveJSONToFile(0, $jsonFileName)
        # Reset extractor
        $jsonExtractor.Reset()
    }
}
catch {
    Write-Host $_.Exception.Message
}

$jsonExtractor.Dispose()
```

<!-- code block end -->