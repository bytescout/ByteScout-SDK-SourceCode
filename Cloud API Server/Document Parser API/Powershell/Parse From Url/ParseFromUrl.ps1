# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Source PDF file url
$SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/document-parser/MultiPageTable.pdf"

# Destination JSON file name
$DestinationFile = ".\result.json"


try {
    # Parse url
    # Template text. Use Document Parser (https://pdf.co/document-parser, https://app.pdf.co/document-parser)
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
