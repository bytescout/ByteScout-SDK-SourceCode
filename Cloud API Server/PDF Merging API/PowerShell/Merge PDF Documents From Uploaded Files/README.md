## How to merge PDF documents from uploaded files for PDF merging API in PowerShell using ByteScout Cloud API Server

### Step By Step Instructions on how to merge PDF documents from uploaded files for PDF merging API in PowerShell

On this page, you will find sample source codes which show you how to handle a complex task, such as, PDF merging API in PowerShell. ByteScout Cloud API Server was designed to assist PDF merging API in PowerShell. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

Use the code displayed below in your application to save a lot of time on writing and testing code. Follow the tutorial and copy - paste code for PowerShell into your project's code editor. You can use these PowerShell sample examples in one or many applications.

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

##### ****MergePdfDocumentsFromUploadedFiles.ps1:**
    
```
# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Source PDF files
$SourceFiles = ".\sample1.pdf", ".\sample2.pdf"
# Destination PDF file name
$DestinationFile = ".\result.pdf"

$uploadedFiles = @()

try {
    foreach ($pdfFile in $SourceFiles ) {
        # 1a. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
        
        # Prepare URL for `Get Presigned URL` API call
        $query = "https://localhost/file/upload/get-presigned-url?contenttype=application/octet-stream&name=" + `
            [IO.Path]::GetFileName($pdfFile)
        $query = [System.Uri]::EscapeUriString($query)

        # Execute request
        $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query
    
        if ($jsonResponse.error -eq $false) {
            # Get URL to use for the file upload 
            $uploadUrl = $jsonResponse.presignedUrl
            # Get URL of uploaded file to use with later API calls
            $uploadedFileUrl = $jsonResponse.url
    
            # 1b. UPLOAD THE FILE TO CLOUD.
    
            $r = Invoke-WebRequest -Method Put -Headers @{ "content-type" = "application/octet-stream" } -InFile $pdfFile -Uri $uploadUrl
            
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
        # 2. MERGE UPLOADED PDF DOCUMENTS
    
        # Prepare URL for `Merge PDF` API call
        $query = "https://localhost/pdf/merge?name={0}&url={1}" -f `
            $(Split-Path $DestinationFile -Leaf), $($uploadedFiles -join ",")
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

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\MergePdfDocumentsFromUploadedFiles.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->