# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("x-api-key", "{{x-api-key}}")
$headers.Add("Content-Type", "application/json")

$body = "{`n    `"url`": `"https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf`"`n}"

$response = Invoke-RestMethod 'https://localhost/file/hash' -Method 'POST' -Headers $headers -Body $body
$response | ConvertTo-Json