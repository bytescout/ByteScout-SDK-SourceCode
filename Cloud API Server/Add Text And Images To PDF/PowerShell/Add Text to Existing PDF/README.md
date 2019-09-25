## How to add text and images to PDF in PowerShell using ByteScout Cloud API Server

### Learn to code in PowerShell to add text and images to PDF with this step-by-step tutorial

ByteScout simple and easy to understand tutorials are planned to describe the code for both PowerShell beginners and advanced programmers. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing.. It can add text and images to PDF in PowerShell.

Want to quickly learn? This fast application programming interfaces of ByteScout Cloud API Server for PowerShell plus the guidelines and the code below will help you quickly learn how to add text and images to PDF. This PowerShell sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout Cloud API Server in PowerShell is also described in the documentation included along with the product.

The trial version of ByteScout Cloud API Server can be downloaded for free from our website. It also includes source code samples for PowerShell and other programming languages.

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

##### ****AddTextToExistingPDF.ps1:**
    
```
# Direct URL of source PDF file.
$SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf"

#Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
$Pages = ""

# PDF document password. Leave empty for unprotected documents.
$Password = ""

# Destination PDF file name
$DestinationFile = "./result.pdf"

# Text annotation params
$Type = "annotation";
$X = 400;
$Y = 600;
$Text = "APPROVED";
$FontName = "Times New Roman";
$FontSize = 24;
$Color = "FF0000";

$resultFileName = [System.IO.Path]::GetFileName($DestinationFile)

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost".
# If it's not then please replace this with with your hosting url.

# * Add Text *
# Prepare request to `PDF Edit` API endpoint
$query = "https://localhost/pdf/edit/add?name=$($resultFileName)&password=$($Password)&pages=$($Pages)&url=$($SourceFileUrl)&type=$($Type)&x=$($X)&y=$($Y)&text=$($Text)&fontname=$($FontName)&size=$($FontSize)&color=$($Color)";
$query = [System.Uri]::EscapeUriString($query)

try {
    # Execute request
    $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query

    if ($jsonResponse.error -eq $false) {
        # Get URL of generated output file
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

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\AddTextToExistingPDF.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->