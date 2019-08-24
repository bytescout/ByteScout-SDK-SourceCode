# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Direct URLs of PDF documents to merge
$SourceFiles = @(
    "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-merge/sample1.pdf",
    "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-merge/sample2.pdf"
)
# Destination PDF file name
$DestinationFile = ".\result.pdf"

# Prepare URL for `Merge PDF` API call
$query = "https://localhost/pdf/merge?name={0}&url={1}" -f `
    $(Split-Path $DestinationFile -Leaf), $($SourceFiles -join ",")
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
