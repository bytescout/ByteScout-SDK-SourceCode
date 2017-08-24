# (!) If you are getting '(403) Forbidden' error please ensure you have set the correct API_KEY

# The authentication key (API Key).
# Get your own by registering at https://secure.bytescout.com/users/sign_up
$API_KEY = "***********************************"

# Result file name
$ResultFile = ".\barcode.png"
# Barcode type. See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeGenerateGet
$BarcodeType = "Code128"
# Barcode value
$BarcodeValue = "qweasd123456"

$requestHeaders = @{
    "x-api-key" = $API_KEY
}

$resultFileName = [System.IO.Path]::GetFileName($ResultFile)
$uri = "https://bytescout.io/v1/barcode/generate?name=$($resultFileName)&type=$($BarcodeType)&value=$($BarcodeValue)"
$uri = [System.Uri]::EscapeUriString($uri)

try {
    $jsonResponse = Invoke-RestMethod -Method Get -Headers $requestHeaders -Uri $uri

    if ($jsonResponse.error -eq $false) {
        # Get URL of generated barcode image file
        $resultFileUrl = $jsonResponse.url
        
        # Download the image file
        Invoke-WebRequest -Uri $resultFileUrl -OutFile $ResultFile

        Write-Host "Generated barcode saved to '$($ResultFile)' file."
    }
    else {
        Write-Host $jsonResponse.message
    }
}
catch {
    Write-Host $_.Exception
}
