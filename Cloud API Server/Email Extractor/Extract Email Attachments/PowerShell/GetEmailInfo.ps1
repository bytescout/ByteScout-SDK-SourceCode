# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("Content-Type", "application/json")
$headers.Add("x-api-key", "{{x-api-key}}")

$multipartContent = [System.Net.Http.MultipartFormDataContent]::new()
$stringHeader = [System.Net.Http.Headers.ContentDispositionHeaderValue]::new("form-data")
$stringHeader.Name = "url"
$StringContent = [System.Net.Http.StringContent]::new("https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/email-extractor/sample.eml")
$StringContent.Headers.ContentDisposition = $stringHeader
$multipartContent.Add($stringContent)

$body = $multipartContent

$response = Invoke-RestMethod 'https://localhost/email/extract-attachments' -Method 'POST' -Headers $headers -Body $body
$response | ConvertTo-Json