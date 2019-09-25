## How to read barcode from URL for barcode reader API in PowerShell using ByteScout Cloud API Server

### How to read barcode from URL for barcode reader API in PowerShell: Step By Step Instructions

Quick guide:Learn how to read barcode from URL in PowerShell. Barcode reader API in PowerShell can be applied with ByteScout Cloud API Server. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

If you want to speed up the application’s code writing then PowerShell code samples for PowerShell developers help to implement using ByteScout Cloud API Server.  This sample code in PowerShell is all you need. Just copy-paste it to the code editor, then add a reference to ByteScout Cloud API Server and you are ready to try it! You can use these PowerShell sample examples in one or many applications.

Our website provides free trial version of ByteScout Cloud API Server that gives source code samples to assist with your PowerShell project.

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

##### ****ReadBarcodeFromURL.ps1:**
    
```
# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Direct URL of source file to search barcodes in.
$SourceFileURL = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf"
# Comma-separated list of barcode types to search. 
$BarcodeTypes = "Code128,Code39,Interleaved2of5,EAN13"
# Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
$Pages = ""

# Prepare URL for `Barcode Reader` API call
$query = "https://localhost/barcode/read/from/url?types=$($BarcodeTypes)&pages=$($Pages)&url=$($SourceFileURL)"
$query = [System.Uri]::EscapeUriString($query)

try {
    # Execute request
    $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query

    if ($jsonResponse.error -eq $false) {
        # Display found barcodes in console
        foreach ($barcode in $jsonResponse.barcodes)
        {
            Write-Host "Found barcode:"
            Write-Host "  Type: " $barcode.TypeName
            Write-Host "  Value: " $barcode."Value"
            Write-Host "  Document Page Index: " $barcode."Page"
            Write-Host "  Rectangle: " $barcode."Rect"
            Write-Host "  Confidence: " $barcode."Confidence"
            Write-Host ""
        }
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

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ReadBarcodeFromURL.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->