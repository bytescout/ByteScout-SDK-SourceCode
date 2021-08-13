# The authentication key (API Key).
# Get your own by registering at https://app.pdf.co/documentation/api
$API_KEY = "******************************"

# Direct URL of source PDF file.
$SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf"

#Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
$Pages = ""

# PDF document password. Leave empty for unprotected documents.
$Password = ""

# Destination PDF file name
$DestinationFile = "./result.pdf"

# Text annotation params
$X = 400;
$Y = 600;
$Text = "APPROVED";
$FontName = "Times New Roman";
$FontSize = 24;
$Color = "FF0000";

$resultFileName = [System.IO.Path]::GetFileName($DestinationFile)

# * Add Text *
# Prepare request to `PDF Edit` API endpoint
$query = "https://api.pdf.co/v1/pdf/edit/add"

# Prepare request body (will be auto-converted to JSON by Invoke-RestMethod)
# See documentation: https://apidocs.pdf.co
$body = @{
    "name" = $resultFileName
    "url" = $SourceFileUrl
    "password" = $Password
    "annotations" = @(
        @{
            "pages" = $Pages
            "x" = $X
            "y" = $Y
            "text" = $Text
            "fontname" = $FontName
            "size" = $FontSize
            "color" = $Color
        }
    )
} | ConvertTo-Json

try {
    # Execute request
    $response = Invoke-WebRequest -Method Post -Headers @{ "x-api-key" = $API_KEY; "Content-Type" = "application/json" } -Body $body -Uri $query

    $jsonResponse = $response.Content | ConvertFrom-Json

    if ($jsonResponse.error -eq $false) {
        # Get URL of generated output file
        $resultFileUrl = $jsonResponse.url
        
        # Download output file
        Invoke-WebRequest -Uri $resultFileUrl -OutFile $DestinationFile

        Write-Host "Generated PDF saved to '$($DestinationFile)' file."
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
