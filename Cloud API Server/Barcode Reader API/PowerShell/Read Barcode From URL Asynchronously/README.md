## How to read barcode from URL asynchronously for barcode reader API in PowerShell using ByteScout Cloud API Server

### How to read barcode from URL asynchronously in PowerShell with easy ByteScout code samples to make barcode reader API. Step-by-step tutorial

If you want a quick and easy way to add a required functionality into your application then check this sample source code documentation. ByteScout Cloud API Server was designed to assist barcode reader API in PowerShell. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

If you want to speed up the application’s code writing then PowerShell code samples for PowerShell developers help to implement using ByteScout Cloud API Server. This PowerShell sample code can be used by copying and pasting into your project. Once done,just compile your project and click Run. Enjoy writing a code with ready-to-use sample PowerShell codes to add barcode reader API functions using ByteScout Cloud API Server in PowerShell.

Free! Free! Free! ByteScout free trial version is available for FREE download from our website. Programming tutorials along with source code samples are assembled.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Cloud%20API%20Server%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Cloud%20API%20Server%20Question) 

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

##### ****ReadBarcodeFromUrlAsynchronously.ps1:**
    
```
# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Cloud API asynchronous "Barcode Reader" job example.
# Allows to avoid timeout errors when processing huge or scanned PDF documents.

# Direct URL of source file to search barcodes in.
$SourceFileURL = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf"
# Comma-separated list of barcode types to search. 
$BarcodeTypes = "Code128,Code39,Interleaved2of5,EAN13"
# Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
$Pages = ""
# (!) Make asynchronous job
$Async = $true

# Prepare URL for `Barcode Reader` API call
$query = "https://localhost/barcode/read/from/url?types=$($BarcodeTypes)&pages=$($Pages)&url=$($SourceFileURL)&async=$($Async)"
$query = [System.Uri]::EscapeUriString($query)

try {
    # Execute request
    $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query

    if ($jsonResponse.error -eq $false) {
        # Asynchronous job ID
        $jobId = $jsonResponse.jobId
        # URL of generated JSON file with decoded barcodes that will available after the job completion
        $resultFileUrl = $jsonResponse.url

        # Check the job status in a loop. 
        # If you don't want to pause the main thread you can rework the code 
        # to use a separate thread for the status checking and completion.
        do {
            $statusCheckUrl = "https://localhost/job/check?jobid=" + $jobId
            $jsonStatus = Invoke-RestMethod -Method Get  -Uri $statusCheckUrl

            # Display timestamp and status (for demo purposes)
            Write-Host "$(Get-date): $($jsonStatus.status)"

            if ($jsonStatus.status -eq "success") {
                # Download JSON file with decoded barcodes
                $jsonFoundBarcodes = Invoke-RestMethod -Method Get  -Uri $resultFileUrl
                
                # Display found barcodes in console
                foreach ($barcode in $jsonFoundBarcodes)
                {
                    Write-Host "Found barcode:"
                    Write-Host "  Type: " + $barcode.TypeName
                    Write-Host "  Value: " + $barcode."Value"
                    Write-Host "  Document Page Index: " + $barcode."Page"
                    Write-Host "  Rectangle: " + $barcode."Rect"
                    Write-Host "  Confidence: " + $barcode."Confidence"
                    Write-Host ""
                }
                break
            }
            elseif ($jsonStatus.status -eq "working") {
                # Pause for a few seconds
                Start-Sleep -Seconds 3
            }
            else {
                Write-Host $jsonStatus.status
                break
            }
        }
        while ($true)
    }
    else {
        # Display service reported error
        Write-Host $jsonResponse.message
    }
}
catch {
    # Display request error
    Write-Host $_.Exception
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****run.bat:**
    
```
@echo off

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ReadBarcodeFromUrlAsynchronously.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->