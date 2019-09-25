## How to generate PDF invoice from HTML template for HTML to PDF API in PowerShell and ByteScout Cloud API Server

### Follow this simple tutorial to learn generate PDF invoice from HTML template to have HTML to PDF API in PowerShell

Check these thousands of pre-made source code samples for simple implementation in your own programming projects. ByteScout Cloud API Server was designed to assist HTML to PDF API in PowerShell. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

The SDK samples displayed below below explain how to quickly make your application do HTML to PDF API in PowerShell with the help of ByteScout Cloud API Server. Open your PowerShell project and simply copy & paste the code and then run your app! Enjoy writing a code with ready-to-use sample PowerShell codes to add HTML to PDF API functions using ByteScout Cloud API Server in PowerShell.

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

##### ****GeneratePdfInvoiceFromHtmlTemplate.ps1:**
    
```
# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# HTML template
$Template = [IO.File]::ReadAllText(".\invoice_template.html")
# Data to fill the template
$TemplateData = [IO.File]::ReadAllText(".\invoice_data.json")
# Destination PDF file name
$DestinationFile = ".\result.pdf"

# Prepare URL for HTML to PDF API call
$query = "https://localhost/pdf/convert/from/html?name=$(Split-Path $DestinationFile -Leaf)"
$query = [System.Uri]::EscapeUriString($query)

# Prepare request body (will be auto-converted to JSON by Invoke-RestMethod)
$body = @{
    "html" = $Template
    "templateData" = $TemplateData
} | ConvertTo-Json

try {
    # Execute request
    $response = Invoke-WebRequest -Method Post -Headers @{ "Content-Type" = "application/json" } -Body $body -Uri $query

    if ($response.StatusCode -eq 200) {
        
        $jsonResponse = $response.Content | ConvertFrom-Json

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
    else {
        # Display request error status
        Write-Host $response.StatusCode + " " + $response.StatusDescription
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

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\GeneratePdfInvoiceFromHtmlTemplate.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->