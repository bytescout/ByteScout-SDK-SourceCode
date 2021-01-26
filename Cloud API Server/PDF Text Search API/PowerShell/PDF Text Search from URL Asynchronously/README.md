## How to PDF text search API in PowerShell using ByteScout Cloud API Server ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Cloud%20API%20Server%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Cloud%20API%20Server%20Question) 

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

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### **PDFTextSearchFromUrlAsynchronously.ps1:**
    
```
# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Direct URL of PDF file to get information
$SourceFileURL = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf"

# Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
$Pages = ""

# PDF document password. Leave empty for unprotected documents.
$Password = ""

# Search string. 
$SearchString = '\d{1,}\.\d\d' #Regular expression to find numbers like '100.00'

# Enable regular expressions (Regex) 
$RegexSearch = 'True'

# (!) Make asynchronous job
$Async = $true

# Prepare URL for PDF text search API call.
$query = "https://localhost/pdf/find?password=$($Password)&pages=$($Pages)&url=$($SourceFileURL)&searchString=$($SearchString)&regexSearch=$($RegexSearch)&async=$($Async)"
$query = [System.Uri]::EscapeUriString($query)

try {
    # Execute request
    $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query

    if ($jsonResponse.error -eq $false) {
        # Asynchronous job ID
        $jobId = $jsonResponse.jobId

        # URL of generated JSON file with search result that will available after the job completion
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
                # Get JSON for search result
                $jsonSearchResult = Invoke-RestMethod -Method Get  -Uri $resultFileUrl
                
                # Display found result in console
                foreach ($item in $jsonSearchResult)
                {
                    Write-Host "Found text $($item.text) at coordinates $($item.left), $($item.top)"
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

##### **run.bat:**
    
```
@echo off

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\PDFTextSearchFromUrlAsynchronously.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->