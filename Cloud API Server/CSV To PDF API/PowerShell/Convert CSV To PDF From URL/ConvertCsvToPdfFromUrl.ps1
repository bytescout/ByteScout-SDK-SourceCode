# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Direct URL of source CSV file.
$SourceFileURL = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/csv-to-pdf/sample.csv"
# Destination PDF file name
$DestinationFile = ".\result.pdf"

# Prepare URL for `CSV To PDF` API call
$query = "https://localhost/pdf/convert/from/csv?name=$(Split-Path $DestinationFile -Leaf)&url=$($SourceFileURL)"
$query = [System.Uri]::EscapeUriString($query)

try {
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
catch {
    # Display request error
    Write-Host $_.Exception
}
