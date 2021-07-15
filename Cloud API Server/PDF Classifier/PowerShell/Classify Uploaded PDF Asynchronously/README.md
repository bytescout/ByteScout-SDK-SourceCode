## PDF classifier in PowerShell using ByteScout Cloud API Server ByteScout Cloud API Server is the ready to deploy Web API Server that can be deployed in less than thirty minutes into your own in-house Windows server (no Internet connnection is required to process data!) or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using built-in ByteScout powered engine, no cloud services are used to process your data!.

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

##### **ClassifyPdfWithUploadAsync.ps1:**
    
```
$APIBaseURL='http://localhost:80'

$scriptDir = Split-Path -Path $MyInvocation.MyCommand.Definition -Parent

$InputFile = "$scriptDir\sample.pdf"

$RulesSpreadsheet = "$scriptDir\rules.csv"
$RulesColumnIndex = 1
$ResultIdentifiersColumnIndex = 0

function main() 
{
    $rules = Get-Content -Path $RulesSpreadsheet | Out-String

    Write-Host "Uploading document `"$InputFile`"" -ForegroundColor Green
    $fileUrl = UploadFile $InputFile
    
    if ($null -ne $fileUrl) {
        Write-Host "Processing document..."
        $result = ClassifyDocument $fileUrl $rules
        if ($null -ne $result) {
            Write-Host "Detected classes:"
            foreach ($elem in $result.classes) {
                Write-Host $elem.class
            }
        }
    }
}

function ClassifyDocument($fileUrl, $rules)
{
    # Prepare URL for `pdf/classifier` API call
    $query = "$APIBaseURL/pdf/classifier"
    # Prepare POST request body
    $body = @{
        "async" = "true";
        "url" = $fileUrl;
        "rulescsv" = $rules;
        "caseSensitive" = $false
    } | ConvertTo-Json

    # Note, rules can also be passed as URL of file `rulesCsvUrl` param instead of `rulesCsv`.
    # Rules can be a spreadhset in CSV, XLS, XLSX, ODS format.

    try {
        # Execute request
        $jsonResponse = Invoke-RestMethod -Method Post -Uri $query -Body $body

        if ($jsonResponse.error -eq $false) {
            # Asynchronous job ID
            $jobId = $jsonResponse.jobId
            # URL of generated TXT file that will available after the job completion
            $resultFileUrl = $jsonResponse.url

            # Check the job status in a loop. 
            do {
                $statusCheckUrl = "{0}/job/check?jobid={1}" -f $APIBaseURL, $jobId
                $jsonStatus = Invoke-RestMethod -Method Get -Uri $statusCheckUrl

                # Display timestamp and status (for demo purposes)
                Write-Host "$(Get-date): $($jsonStatus.status)"

                if ($jsonStatus.status -eq "success") {
                    # Download result
                    return Invoke-WebRequest -Uri $resultFileUrl | ConvertFrom-Json
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
        # Display exception if any
        Write-Host $_.Exception
    }

    return $null
}

function UploadFile($filePath)
{
    # Prepare URL for `Get Presigned URL` API call
    $query = "{0}/file/upload/get-presigned-url?contenttype=application/octet-stream&name={1}" -f `
        $APIBaseURL, [System.IO.Path]::GetFileName($filePath)
    $query = [System.Uri]::EscapeUriString($query)

    try {
        # Execute request
        $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query
        
        if ($jsonResponse.error -eq $false) {
            # Get URL to use for the file upload
            $uploadUrl = $jsonResponse.presignedUrl
            # Get URL of uploaded file to use with later API calls
            $uploadedFileUrl = $jsonResponse.url
    
            # UPLOAD THE FILE
            $r = Invoke-WebRequest -Method Put -Headers @{ "content-type" = "application/octet-stream" } -InFile $filePath -Uri $uploadUrl
            
            if ($r.StatusCode -eq 200) {
                return $uploadedFileUrl
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
    catch {
        # Display request error
        Write-Host $_.Exception
    }

    return $null;
}

main

trap {
    Write-Host "Exception: $_" -ForegroundColor White -BackgroundColor DarkRed
    exit 1
}


```

<!-- code block end -->    

<!-- code block begin -->

##### **run.bat:**
    
```
@echo off

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ClassifyPdfWithUploadAsync.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->