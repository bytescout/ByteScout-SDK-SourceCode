# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# URL of web page to convert to PDF document.
$SourceUrl = "http://www.usa.gov"
# Destination PDF file name
$DestinationFile = ".\result.pdf"

# Prepare URL for `Web Page to PDF` API call
$query = "https://localhost/pdf/convert/from/url?name=$(Split-Path $DestinationFile -Leaf)&url=$($SourceUrl)"
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
