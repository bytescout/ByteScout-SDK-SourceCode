## How to parse from url for document parser API in Powershell and ByteScout Cloud API Server

### How to parse from url in Powershell with easy ByteScout code samples to make document parser API. Step-by-step tutorial

Check these thousands of pre-made source code samples for simple implementation in your own programming projects. ByteScout Cloud API Server helps with document parser API in Powershell. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

The SDK samples displayed below below explain how to quickly make your application do document parser API in Powershell with the help of ByteScout Cloud API Server. This Powershell sample code can be used by copying and pasting into your project. Once done,just compile your project and click Run. This basic programming language sample code for Powershell will do the whole work for you in implementing document parser API in your app.

ByteScout Cloud API Server - free trial version is available on our website. Also, there are other code samples to help you with your Powershell application included into trial version.

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

##### **MultiPageTable-template1.yml:**
    
```
---
# Template that demonstrates parsing of multi-page table using only 
# regular expressions for the table start, end, and rows.
# If regular expression cannot be written for every table row (for example, 
# if the table contains empty cells), try the second method demonstrated 
# in 'MultiPageTable-template2.yml' template.
templateVersion: 2
templatePriority: 0
sourceId: Multipage Table Test
detectionRules:
  keywords:
  - Sample document with multi-page table
fields:
  total:
    expression: TOTAL {{DECIMAL}}    
tables:
- name: table1
  start:
    # regular expression to find the table start in document
    expression: Item\s+Description\s+Price\s+Qty\s+Extended Price
  end:
    # regular expression to find the table end in document
    expression: TOTAL\s+\d+\.\d\d
  row:
    # regular expression to find table rows
    expression: '^\s*(?<itemNo>\d+)\s+(?<description>.+?)\s+(?<price>\d+\.\d\d)\s+(?<qty>\d+)\s+(?<extPrice>\d+\.\d\d)'
  columns: 
  - name: itemNo
    type: integer
  - name: description
    type: string
  - name: price
    type: decimal
  - name: qty
    type: integer
  - name: extPrice
    type: decimal
  multipage: true
```

<!-- code block end -->    

<!-- code block begin -->

##### **ParseFromUrl.ps1:**
    
```
# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Source PDF file url
$SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/document-parser/MultiPageTable.pdf"

# Destination JSON file name
$DestinationFile = ".\result.json"


try {
    # Parse url
    # Template text. Use Document Parser SDK (https://bytescout.com/products/developer/documentparsersdk/index.html)
    # to create templates.
    # Read template from file:
    $templateContent = [IO.File]::ReadAllText(".\MultiPageTable-template1.yml")

    # Prepare URL for `Document Parser` API call
    $query = "https://localhost/pdf/documentparser"

    # Content
    $Body = @{
        "url" = $SourceFileUrl;
        "template" = $templateContent;
    }
    
    # Execute request
    $jsonResponse = Invoke-RestMethod -Method 'Post' -Uri $query -Body ($Body|ConvertTo-Json) -ContentType "application/json"
    if ($jsonResponse.error -eq $false) {
        # Get URL of generated HTML file
        $resultFileUrl = $jsonResponse.url;
        
        # Download output file
        Invoke-WebRequest -OutFile $DestinationFile -Uri $resultFileUrl
        Write-Host "Generated output file saved as `"$($DestinationFile)`" file."
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

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ParseFromUrl.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->