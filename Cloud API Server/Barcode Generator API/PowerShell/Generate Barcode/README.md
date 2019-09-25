## How to generate barcode for barcode generator API in PowerShell and ByteScout Cloud API Server

### Learn in simple ways: How to generate barcode for barcode generator API in PowerShell

The sample source codes on this page will show you how to create barcode generator API in PowerShell. ByteScout Cloud API Server helps with barcode generator API in PowerShell. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

The SDK samples displayed below below explain how to quickly make your application do barcode generator API in PowerShell with the help of ByteScout Cloud API Server.  This sample code in PowerShell is all you need. Just copy-paste it to the code editor, then add a reference to ByteScout Cloud API Server and you are ready to try it! Enjoy writing a code with ready-to-use sample PowerShell codes to add barcode generator API functions using ByteScout Cloud API Server in PowerShell.

Trial version of ByteScout is available for free download from our website. This and other source code samples for PowerShell and other programming languages are available.

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

##### ****GenerateBarcode.ps1:**
    
```
# Result file name
$ResultFile = ".\barcode.png"
# Barcode type.
$BarcodeType = "Code128"
# Barcode value
$BarcodeValue = "qweasd123456"

$resultFileName = [System.IO.Path]::GetFileName($ResultFile)

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.
$query = "https://localhost/barcode/generate?name=$($resultFileName)&type=$($BarcodeType)&value=$($BarcodeValue)"
$query = [System.Uri]::EscapeUriString($query)

try {
    # Execute request
    $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query

    if ($jsonResponse.error -eq $false) {
        # Get URL of generated barcode image file
        $resultFileUrl = $jsonResponse.url
        
        # Download the image file
        Invoke-WebRequest -Uri $resultFileUrl -OutFile $ResultFile

        Write-Host "Generated barcode saved to '$($ResultFile)' file."
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

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\GenerateBarcode.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->