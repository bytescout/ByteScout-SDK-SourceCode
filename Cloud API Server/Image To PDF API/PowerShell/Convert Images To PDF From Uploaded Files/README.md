## How to convert images to PDF from uploaded files for image to PDF API in PowerShell and ByteScout Cloud API Server

### Follow this simple tutorial to learn convert images to PDF from uploaded files to have image to PDF API in PowerShell

The sample source codes on this page will show you how to create image to PDF API in PowerShell. ByteScout Cloud API Server was designed to assist image to PDF API in PowerShell. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

Use the code displayed below in your application to save a lot of time on writing and testing code. This PowerShell sample code can be used by copying and pasting into your project. Once done,just compile your project and click Run. This basic programming language sample code for PowerShell will do the whole work for you in implementing image to PDF API in your app.

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

##### ****ConvertImagesToPdfFromUploadedFiles.ps1:**
    
```
# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Source image files
$ImageFiles = ".\image1.png", ".\image2.jpg"
# Destination PDF file name
$DestinationFile = ".\result.pdf"

$uploadedFiles = @()

try {
    foreach ($imageFile in $ImageFiles ) {
        # 1a. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
        
        # Prepare URL for `Get Presigned URL` API call
        $query = "https://localhost/file/upload/get-presigned-url?contenttype=application/octet-stream&name=" + `
            [IO.Path]::GetFileName($imageFile)
        $query = [System.Uri]::EscapeUriString($query)

        # Execute request
        $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query
    
        if ($jsonResponse.error -eq $false) {
            # Get URL to use for the file upload 
            $uploadUrl = $jsonResponse.presignedUrl
            # Get URL of uploaded file to use with later API calls
            $uploadedFileUrl = $jsonResponse.url
    
            # 1b. UPLOAD THE FILE TO CLOUD.
    
            $r = Invoke-WebRequest -Method Put -Headers @{ "content-type" = "application/octet-stream" } -InFile $imageFile -Uri $uploadUrl
            
            if ($r.StatusCode -eq 200) {
                # Keep uploaded file URL
                $uploadedFiles += $uploadedFileUrl
            }
            else {
                # Display request error status
                Write-Host $r.StatusCode + " " + $r.StatusDescription
            }
        }
        else {
            # Display service reported error
            Write-Host $jsonResponse.message
        }
    }

    if ($uploadedFiles.length -gt 0) {
        # 2. CREATE PDF DOCUMENT FROM UPLOADED IMAGE FILES
    
        # Prepare URL for `DOC To PDF` API call
        $query = "https://localhost/pdf/convert/from/image?name=$(Split-Path $DestinationFile -Leaf)&url=$($uploadedFiles -join ",")"
        $query = [System.Uri]::EscapeUriString($query)
        
        # Execute request
        $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query

        if ($jsonResponse.error -eq $false) {
            # Get URL of generated PDF file
            $resultFileUrl = $jsonResponse.url;
            
            # Download PDF file
            Invoke-WebRequest  -OutFile $DestinationFile -Uri $resultFileUrl

            Write-Host "Generated PDF file saved as `"$($DestinationFile)`" file."
        }
        else {
            # Display service reported error
            Write-Host $jsonResponse.message
        }   
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

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ConvertImagesToPdfFromUploadedFiles.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->