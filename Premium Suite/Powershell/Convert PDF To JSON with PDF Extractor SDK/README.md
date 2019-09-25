## How to convert PDF to JSON with PDF extractor SDK in Powershell using ByteScout Premium Suite

### This code in Powershell shows how to convert PDF to JSON with PDF extractor SDK with this how to tutorial

The documentation is designed for a specific purpose to help you to apply the features on your side. Want to convert PDF to JSON with PDF extractor SDK in your Powershell app? ByteScout Premium Suite is designed for it. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for Powershell plus the guidelines and the code below will help you quickly learn how to convert PDF to JSON with PDF extractor SDK. IF you want to implement the functionality, just copy and paste this code for Powershell below into your code editor with your app, compile and run your application. This basic programming language sample code for Powershell will do the whole work for you to convert PDF to JSON with PDF extractor SDK.

You can download free trial version of ByteScout Premium Suite from our website with this and other source code samples for Powershell.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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