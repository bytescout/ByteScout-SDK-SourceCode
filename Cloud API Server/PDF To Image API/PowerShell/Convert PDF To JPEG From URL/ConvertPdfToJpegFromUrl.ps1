# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Direct URL of source PDF file.
$SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-image/sample.pdf"
# Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
$Pages = ""
# PDF document password. Leave empty for unprotected documents.
$Password = ""


# Prepare URL for `PDF To JPEG` API call
$query = "https://localhost/pdf/convert/to/jpg?password={0}&pages={1}&url={2}" -f `
    $Password, $Pages, $SourceFileUrl
$query = [System.Uri]::EscapeUriString($query)

try {
    # Execute request
    $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query

    if ($jsonResponse.error -eq $false) {
        # Download generated JPEG files
        $part = 1;
        foreach ($url in $jsonResponse.urls) {
            $localFileName = ".\page$($part).jpg"

            Invoke-WebRequest  -OutFile $localFileName -Uri $url

            Write-Host "Downloaded `"$($localFileName)`""
            $part++
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
