# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Result file name
$ResultFile = ".\barcode.png"
# Barcode type.
$BarcodeType = "Code128"
# Barcode value
$BarcodeValue = "qweasd123456"

$resultFileName = [System.IO.Path]::GetFileName($ResultFile)

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.
$query = "https://localhost/barcode/generate?name=$($resultFileName)&type=$($BarcodeType)&value=$($BarcodeValue)"
$query = [System.Uri]::EscapeUriString($query)

try {
    # Execute request
    $jsonResponse = Invoke-RestMethod -Method Get  -Uri $query

    if ($jsonResponse.error -eq $false) {
        # Get URL of generated barcode image file
        $resultFileUrl = $jsonResponse.url
        
        # Download the image file
        Invoke-WebRequest -Uri $resultFileUrl -OutFile $ResultFile

        Write-Host "Generated barcode saved to '$($ResultFile)' file."
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
