# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Source PDF file
$SourceFile = ".\MultiPageTable.pdf"

# Destination JSON file name
$DestinationFile = ".\result.json"

# 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
# * If you already have a direct file URL, skip to the step 3.

# Prepare URL for `Get Presigned URL` API call
$query = "https://localhost/file/upload/get-presigned-url?contenttype=application/octet-stream&name=" + `
    [System.IO.Path]::GetFileName($SourceFile)
$query = [System.Uri]::EscapeUriString($query)

try {
    # Execute request
    $jsonResponse = Invoke-RestMethod -Method Get -Uri $query
    
    if ($jsonResponse.error -eq $false) {
        # Get URL to use for the file upload
        $uploadUrl = $jsonResponse.presignedUrl
        # Get URL of uploaded file to use with later API calls
        $uploadedFileUrl = $jsonResponse.url

        # 2. UPLOAD THE FILE TO CLOUD.

        $r = Invoke-WebRequest -Method Put -Headers @{ "content-type" = "application/octet-stream" } -InFile $SourceFile -Uri $uploadUrl
        
        if ($r.StatusCode -eq 200) {
            
            # 3. Parse PDF document by template

            # Template text. Use Document Parser (https://pdf.co/document-parser, https://app.pdf.co/document-parser)
            # to create templates.
            # Read template from file:
            $templateContent = [IO.File]::ReadAllText(".\MultiPageTable-template1.yml")

            # Prepare URL for `Document Parser` API call
            $query = "https://localhost/pdf/documentparser"

            # Content
            $Body = @{
                "url" = $uploadedFileUrl;
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
        else {
            # Display request error status
            Write-Host $r.StatusCode + " " + $r.StatusDescription
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
