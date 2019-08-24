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
