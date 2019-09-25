## How to add text and images to PDF in PowerShell using ByteScout Cloud API Server

### Step-by-step tutorial on how to add text and images to PDF in PowerShell

The code displayed below will guide you to install an PowerShell app to add text and images to PDF. What is ByteScout Cloud API Server? It is the ready to deploy Web API Server that can be deployed in less than thirty minutes into your own in-house Windows server (no Internet connnection is required to process data!) or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using built-in ByteScout powered engine, no cloud services are used to process your data!. It can help you to add text and images to PDF in your PowerShell application.

Want to quickly learn? This fast application programming interfaces of ByteScout Cloud API Server for PowerShell plus the guidelines and the code below will help you quickly learn how to add text and images to PDF. IF you want to implement the functionality, just copy and paste this code for PowerShell below into your code editor with your app, compile and run your application. Use of ByteScout Cloud API Server in PowerShell is also described in the documentation included along with the product.

ByteScout provides the free trial version of ByteScout Cloud API Server along with the documentation and source code samples.

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

##### ****AddImagesToExistingPDF.ps1:**
    
```
# Direct URL of source PDF file.
$SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf"

#Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
$Pages = ""

# PDF document password. Leave empty for unprotected documents.
$Password = ""

# Destination PDF file name
$DestinationFile = "./result.pdf"

# Image params
$Type = "image"
$X = 400
$Y = 20
$Width = 119
$Height = 32
$ImageUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png"

$resultFileName = [System.IO.Path]::GetFileName($DestinationFile)

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# * Add image *
# Prepare request to `PDF Edit` API endpoint
$query = "https://localhost/pdf/edit/add?name=$($resultFileName)&password=$($Password)&pages=$($Pages)&url=$($SourceFileUrl)&type=$($Type)&x=$($X)&y=$($Y)&width=$($Width)&height=$($Height)&urlimage=$($ImageUrl)";
$query = [System.Uri]::EscapeUriString($query)

try {
    # Execute request
    $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query

    if ($jsonResponse.error -eq $false) {
        # Get URL of generated barcode image file
        $resultFileUrl = $jsonResponse.url
        
        # Download output file
        Invoke-WebRequest -Uri $resultFileUrl -OutFile $DestinationFile

        Write-Host "Generated PDF saved to '$($DestinationFile)' file."
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

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\AddImagesToExistingPDF.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->